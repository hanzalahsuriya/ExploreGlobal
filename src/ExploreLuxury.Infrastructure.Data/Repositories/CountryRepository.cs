using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Context;

namespace ExploreLuxury.Infrastructure.Data.Repositories
{
    public class CountryRepository : ICountryRepository 
    {
        public AppDbContext Context = new AppDbContext();

        public System.Linq.IQueryable<Country> Countries
        {
            get
            {
                return Context.Country;
            } 
        }

        public void Save(Country country)
        {
            if ((country.Id == null) || (country.Id == Guid.Empty))
            {
                country.Id = Guid.NewGuid();
                Context.Country.Add(country);
            }
            else
            {
                var existing_hotel = Context.Country.First(x => x.Id == country.Id);
                if (existing_hotel != null)
                {
                    existing_hotel.Name = country.Name;
                    //Add more mapping
                }
            }

            Context.SaveChanges();
        }        
    }
}
