using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Presentation.ModelView;

namespace ExploreLuxury.Presentation.Web.UI.Controllers
{
    public class CityController : Controller
    {
        private ICityRepository cityRepository;
        private ICountryRepository countryRepository;

        public CityController(ICountryRepository cntryRepo,  ICityRepository cityRepo)
        {
            cityRepository = cityRepo;
            countryRepository = cntryRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult List()
        {
            return View(cityRepository.Cities);
        }

        public ActionResult Insert()
        {

            var model = new CityCountries
            {
                Countries = countryRepository.Countries.ToList(),
                City = new City()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Insert(CityCountries cityCountry)
        {
            if (ModelState.IsValid)
            {
                var city = cityCountry.City;
                cityRepository.Save(city);
                return RedirectToAction("List");
            }

            return View(cityCountry);
        }
    }
}