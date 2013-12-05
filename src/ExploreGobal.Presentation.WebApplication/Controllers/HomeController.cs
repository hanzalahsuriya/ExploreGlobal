using ExploreGlobal.Infrastructure.Interfaces;
using ExploreGobal.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ExploreGobal.Presentation.UI.Controllers
{
    public class HomeController : Controller
    {
        private IHotelRepository _hotelRepository;
        private ILoggingService _loggingService;

        public HomeController(IHotelRepository hotelRepo, ILoggingService logservice)
        {
            _hotelRepository = hotelRepo;
            _loggingService = logservice;
        }

        public string Index()
        {
            _loggingService.Warn("GET Action: ProductController.Index");
            StringBuilder sb = new StringBuilder();
            foreach (var h in _hotelRepository.Hotels)
            {
                sb.Append(h.Name + "<br/>");
            }

            return sb.ToString();
        }

    }
}
