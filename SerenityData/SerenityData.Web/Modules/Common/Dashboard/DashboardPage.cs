using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Web;
using System;
using SerenityData.Administration.Entities;
using SerenityData.SerenityData;

namespace SerenityData.Common.Pages
{
    [Route("Dashboard/[action]")]
    public class DashboardController : Controller
    {
        private readonly ISqlConnections _connections;

        public DashboardController(ISqlConnections connections)
        {
            _connections = connections;
        }

        [PageAuthorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            using var connection = _connections.NewByKey("Default");

            var model = new DashboardPageModel
            {
                Suppliers = connection.Count<SuppliersRow>(),
                Products = connection.Count<ProductsRow>(),
                StockTransactions = connection.Count<StockTransactionsRow>(),
                ActiveUsers = connection.Count<UserRow>(UserRow.Fields.IsActive == 1),
                Software = connection.Count<SoftwareRow>(),
                StockNames = connection.Count<StockNamesRow>()
            };

            return View(MVC.Views.Common.Dashboard.DashboardIndex, model);
        }
    }
}
