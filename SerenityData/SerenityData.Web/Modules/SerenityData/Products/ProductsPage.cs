using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(ProductsRow))]
    public class ProductsController : Controller
    {
        [Route("SerenityData/Products")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/Products/ProductsIndex.cshtml");
        }
    }
}