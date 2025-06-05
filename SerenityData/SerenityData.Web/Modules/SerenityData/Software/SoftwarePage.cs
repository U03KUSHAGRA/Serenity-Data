using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(SoftwareRow))]
    public class SoftwareController : Controller
    {
        [Route("SerenityData/Software")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/Software/SoftwareIndex.cshtml");
        }
    }
}