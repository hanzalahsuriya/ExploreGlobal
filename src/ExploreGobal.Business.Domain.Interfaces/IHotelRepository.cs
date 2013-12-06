using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExploreGobal.Business.Domain.Entities;

namespace ExploreGobal.Business.Domain.Interfaces
{
    public interface IHotelRepository
    {
        IQueryable<Hotel> Hotels { get; }

        void Save(Hotel hotel);

        void Delete(int Id);
    }
}