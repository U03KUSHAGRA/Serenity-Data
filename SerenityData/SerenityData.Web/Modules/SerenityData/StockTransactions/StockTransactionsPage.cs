using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(StockTransactionsRow))]
    public class StockTransactionsController : Controller
    {
        [Route("SerenityData/StockTransactions")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/StockTransactions/StockTransactionsIndex.cshtml");
        }
    }
}