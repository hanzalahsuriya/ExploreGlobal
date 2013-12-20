using ExploreGlobal.Infrastructure.Data;
using ExploreGlobal.Infrastructure.Data.Repositories;
using ExploreGlobal.Infrastructure.Interfaces;
using ExploreGlobal.Infrastructure.Logging;
using ExploreGobal.Business.Domain.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGlobal.Infrastructure.DependencyResolution
{
    public class AccountModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<IUserRepository>();
        }
    }
}
