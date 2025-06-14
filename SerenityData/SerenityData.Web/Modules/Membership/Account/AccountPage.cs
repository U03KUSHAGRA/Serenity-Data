﻿using SerenityData.Administration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Abstractions;
using Serenity.Extensions;
using Serenity.Services;
using System;

namespace SerenityData.Membership.Pages
{
    [Route("Account/[action]")]
    public partial class AccountController : Controller
    {
        public ITwoLevelCache Cache { get; }
        public ITextLocalizer Localizer { get; }

        public AccountController(ITwoLevelCache cache, ITextLocalizer localizer)
        {
            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
            Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
        }
        public static bool UseAdminLTELoginBox = false;

        [HttpGet]
        public ActionResult Login(string activated)
        {
            ViewData["Activated"] = activated;
            ViewData["HideLeftNavigation"] = true;

            return View(MVC.Views.Membership.Account.AccountLogin);
        }

        [HttpGet]
        public ActionResult AccessDenied(string returnURL)
        {
            ViewData["HideLeftNavigation"] = !User.IsLoggedIn();

            return View(MVC.Views.Errors.AccessDenied, (object)returnURL);
        }

        [HttpPost, JsonRequest]
        public Result<ServiceResponse> Login(LoginRequest request,
            [FromServices] IUserPasswordValidator passwordValidator,
            [FromServices] IUserRetrieveService userRetriever,
            [FromServices] IEmailSender emailSender = null)
        {
            return this.ExecuteMethod(() =>
            {
                if (request is null)
                    throw new ArgumentNullException(nameof(request));

                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException("username");

                if (passwordValidator is null)
                    throw new ArgumentNullException(nameof(passwordValidator));

                if (userRetriever is null)
                    throw new ArgumentNullException(nameof(userRetriever));

                var username = request.Username;
                var result = passwordValidator.Validate(ref username, request.Password);
                if (result == PasswordValidationResult.Valid)
                {
                    var principal = UserRetrieveService.CreatePrincipal(userRetriever, username, authType: "Password");
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal)
                        .GetAwaiter().GetResult();
                    return new ServiceResponse();
                }

                throw new ValidationError("AuthenticationError", Texts.Validation.AuthenticationError.ToString(Localizer));
            });
        }

        private ActionResult Error(string message)
        {
            return View(MVC.Views.Errors.ValidationError, message);
        }

        public ActionResult Signout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new RedirectResult("~/");
        }
    }
}