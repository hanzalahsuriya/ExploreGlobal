using System.Web.Mvc;

namespace ExploreLuxury.Api.Restful.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
