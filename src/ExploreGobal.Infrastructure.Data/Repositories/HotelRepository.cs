using ExploreGobal.Business.Domain.Interfaces;
using ExploreGobal.Business.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
namespace ExploreGlobal.Infrastructure.Data.Repositories
{
    public class HotelRepository : IHotelRepository 
    {
        public System.Linq.IQueryable<Hotel> Hotels
        {
            get
            {
                List<Hotel> hotels = new List<Hotel> 
                                    { 
                                        new Hotel { Name = "h1" }, 
                                        new Hotel { Name = "h2" }, 
                                        new Hotel { Name = "h3" }, 
                                        new Hotel { Name = "h4" }, 
                                        new Hotel { Name = "h5" } 
                                    };
                
                return hotels.AsQueryable();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
