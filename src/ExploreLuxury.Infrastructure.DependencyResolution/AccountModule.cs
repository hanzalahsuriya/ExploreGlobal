using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Repositories;
using Ninject.Modules;

namespace ExploreLuxury.Infrastructure.DependencyResolution
{
    public class AccountModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
