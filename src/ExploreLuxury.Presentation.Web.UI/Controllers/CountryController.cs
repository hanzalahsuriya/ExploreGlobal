using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;

namespace ExploreLuxury.Presentation.Web.UI.Controllers
{
    public class CountryController : Controller
    {
        private ICountryRepository countryRepository;

        public CountryController(ICountryRepository countryRepo)
        {
            countryRepository = countryRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult List()
        {
            return View(countryRepository.Countries.OrderBy(x=>x.Name));
        }

        public ActionResult Insert()
        {
            return View(new Country());
        }

        [HttpPost]
        public ActionResult Insert(Country country)
        {
            if (ModelState.IsValid)
            {
                countryRepository.Save(country);
                return RedirectToAction("List");
            }

            return View(country);
        }
    }
}