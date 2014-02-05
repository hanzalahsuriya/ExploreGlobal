using ExploreGobal.Business.Domain.Entities;
using ExploreGobal.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExploreGobal.Presentation.UI.Controllers
{
    public class HotelController : Controller
    {
        private IHotelRepository hotelRepository;

        public HotelController(IHotelRepository hRepo)
        {
            hotelRepository = hRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(hotelRepository.Hotels);
        }

        public ActionResult Insert()
        {
            return View(new Hotel());
        }

        [HttpPost]
        public ActionResult Insert(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                hotelRepository.Save(hotel);
                return RedirectToAction("List");
            }

            return View(hotel);
        }

        public ActionResult Edit(Guid hotelId)
        {
            var selectedHotel = hotelRepository.Hotels.FirstOrDefault(x => x.Id == hotelId);
            if (selectedHotel != null)
            {
                return View("Insert", selectedHotel);
            }
            return View("List");
        }

        public ActionResult Delete(Guid hotelId)
        {
            hotelRepository.Delete(hotelId);
            return RedirectToAction("List");
        }
    }
}
