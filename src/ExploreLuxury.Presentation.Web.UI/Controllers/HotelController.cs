using System;
using System.Linq;
using System.Web.Mvc;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;

namespace ExploreLuxury.Presentation.Web.UI.Controllers
{
    [Authorize]
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

        [AllowAnonymous]
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
