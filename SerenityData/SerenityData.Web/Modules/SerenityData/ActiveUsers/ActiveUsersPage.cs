using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenityData.SerenityData.Pages
{

    [PageAuthorize(typeof(ActiveUsersRow))]
    public class ActiveUsersController : Controller
    {
        [Route("SerenityData/ActiveUsers")]
        public ActionResult Index()
        {
            return View("~/Modules/SerenityData/ActiveUsers/ActiveUsersIndex.cshtml");
        }
    }
}