using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(StockNamesRow))]
    public class StockNamesController : Controller
    {
        [Route("SerenityData/StockNames")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/StockNames/StockNamesIndex.cshtml");
        }
    }
}