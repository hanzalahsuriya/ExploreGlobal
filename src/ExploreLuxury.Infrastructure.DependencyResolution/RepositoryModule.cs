using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Repositories;
using Ninject.Modules;

namespace ExploreLuxury.Infrastructure.DependencyResolution
{
    public class RepositoryModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IHotelRepository>().To<HotelRepository>();
            Bind<ICountryRepository>().To<CountryRepository>();
            Bind<ICityRepository>().To<CityRepository>();
        }
    }
}
