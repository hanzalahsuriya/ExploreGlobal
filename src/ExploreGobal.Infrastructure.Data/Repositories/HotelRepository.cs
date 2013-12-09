using ExploreGobal.Business.Domain.Interfaces;
using ExploreGobal.Business.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ExploreGlobal.Infrastructure.Data.Context;
using System;
namespace ExploreGlobal.Infrastructure.Data.Repositories
{
    public class HotelRepository : IHotelRepository 
    {
        public HotelContext context = new HotelContext();

        public System.Linq.IQueryable<Hotel> Hotels
        {
            get
            {
                return context.Hotels;
            } 
        }

        public void Save(Hotel hotel)
        {
            if ((hotel.Id == null) || (hotel.Id == Guid.Empty))
            {
                hotel.Id = Guid.NewGuid();
                context.Hotels.Add(hotel);
            }
            else
            {
                var existing_hotel = context.Hotels.First(x => x.Id == hotel.Id);
                if (existing_hotel != null)
                {
                    existing_hotel.Name = hotel.Name;
                    //Add more mapping
                }
            }

            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            
        }
        
        
    }
}
