using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;

namespace ExploreLuxury.Business.Domain.Interfaces
{
    public interface IHotelRepository
    {
        IQueryable<Hotel> Hotels { get; }

        void Save(Hotel hotel);

        void Delete(Guid hotelId);
    }
}