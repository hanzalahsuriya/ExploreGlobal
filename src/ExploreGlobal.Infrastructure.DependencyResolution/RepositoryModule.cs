using ExploreGlobal.Infrastructure.Data;
using ExploreGobal.Business.Domain.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGlobal.Infrastructure.DependencyResolution
{
    public class RepositoryModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IHotelRepository>().To<IHotelRepository>();
        }
    }
}
