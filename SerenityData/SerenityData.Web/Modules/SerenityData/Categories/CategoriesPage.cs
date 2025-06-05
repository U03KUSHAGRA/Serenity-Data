using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(CategoriesRow))]
    public class CategoriesController : Controller
    {
        [Route("SerenityData/Categories")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/Categories/CategoriesIndex.cshtml");
        }
    }
}