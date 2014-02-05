using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Context;

namespace ExploreLuxury.Infrastructure.Data.Repositories
{
    public class HotelRepository : IHotelRepository 
    {
        public AppDbContext Context = new AppDbContext();
        
        public System.Linq.IQueryable<Hotel> Hotels
        {
            get
            {
                return Context.Hotels;
            } 
        }

        public void Save(Hotel hotel)
        {
            if ((hotel.Id == null) || (hotel.Id == Guid.Empty))
            {
                hotel.Id = Guid.NewGuid();
                Context.Hotels.Add(hotel);
            }
            else
            {
                var existing_hotel = Context.Hotels.First(x => x.Id == hotel.Id);
                if (existing_hotel != null)
                {
                    existing_hotel.Name = hotel.Name;
                    //Add more mapping
                }
            }

            Context.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var hotel = Context.Hotels.FirstOrDefault(x=>x.Id == Id);

            if (hotel != null)
            {
                Context.Hotels.Remove(hotel);
                Context.SaveChanges();
            }
        }
        
        
    }
}
