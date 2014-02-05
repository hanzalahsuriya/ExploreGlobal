using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Context;

namespace ExploreLuxury.Infrastructure.Data.Repositories
{
    public class CityRepository : ICityRepository 
    {
        public AppDbContext Context = new AppDbContext();

        public System.Linq.IQueryable<City> Cities
        {
            get
            {
                return Context.City;
            } 
        }

        public void Save(City city)
        {
            if ((city.Id == null) || (city.Id == Guid.Empty))
            {
                city.Id = Guid.NewGuid();
                Context.City.Add(city);
            }
            else
            {
                var existing_hotel = Context.City.First(x => x.Id == city.Id);
                if (existing_hotel != null)
                {
                    existing_hotel.Name = city.Name;
                    //Add more mapping
                }
            }

            Context.SaveChanges();
        }  
    }
}
