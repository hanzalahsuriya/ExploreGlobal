using System.Reflection;
using ExploreGlobal.Infrastructure.Interfaces;
using ExploreGobal.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace ExploreGobal.Presentation.UI.Controllers
{
    public class HomeController : Controller
    {
        ILoggingService _loggingService;

        public HomeController(ILoggingService logservice)
        {
            _loggingService = logservice;
        }

        public ViewResult Index()
        {
            /*_loggingService.Warn("GET Action: ProductController.Index");         
            _loggingService.Error(string.Format("Workflow {0}.", Guid.NewGuid()));
            
            return View(_hotelRepository.Hotels);*/
            _loggingService.Info("Home page");
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
