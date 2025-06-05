using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(TotalSalesRow))]
    public class TotalSalesController : Controller
    {
        [Route("SerenityData/TotalSales")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/TotalSales/TotalSalesIndex.cshtml");
        }
    }
}