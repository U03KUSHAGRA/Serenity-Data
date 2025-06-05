using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(TenantsRow))]
    public class TenantsController : Controller
    {
        [Route("SerenityData/Tenants")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/Tenants/TenantsIndex.cshtml");
        }
    }
}