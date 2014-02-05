using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;

namespace ExploreLuxury.Business.Domain.Interfaces
{
    public interface ICityRepository
    {
        IQueryable<City> Cities { get; }

        void Save(City city);

    }
}