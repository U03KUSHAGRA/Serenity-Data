using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(SuppliersRow))]
    public class SuppliersController : Controller
    {
        [Route("SerenityData/Suppliers")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/Suppliers/SuppliersIndex.cshtml");
        }
    }
}