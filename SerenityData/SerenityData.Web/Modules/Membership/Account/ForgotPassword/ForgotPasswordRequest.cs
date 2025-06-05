using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.ComponentModel;

namespace SerenityData.Membership
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordRequest : ServiceRequest
    {
        [Required(true), EmailAddressEditor, DisplayName("E-mail Address")]
        [Placeholder("E-mail address")]
        public String Email { get; set; }
    }
}