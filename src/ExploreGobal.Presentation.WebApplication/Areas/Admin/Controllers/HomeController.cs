using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExploreGobal.Presentation.UI.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            return Content("Test");
        }
    }
}
