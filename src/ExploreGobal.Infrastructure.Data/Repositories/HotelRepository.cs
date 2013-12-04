using ExploreGobal.Business.Domain.Interfaces;
using ExploreGobal.Business.Domain.Entities;
namespace ExploreGlobal.Infrastructure.Data.Repositories
{
    public class HotelRepository : IHotelRepository 
    {
        public System.Linq.IQueryable<Hotel> Hotels
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
