using System;
using System.Linq;
using ExploreLuxury.Business.Domain.Entities;

namespace ExploreLuxury.Business.Domain.Interfaces
{
    public interface ICountryRepository
    {
        IQueryable<Country> Countries { get; }

        void Save(Country country);

    }
}