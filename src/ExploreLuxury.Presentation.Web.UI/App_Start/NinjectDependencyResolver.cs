using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ExploreLuxury.Infrastructure.DependencyResolution;
using Ninject;
using Ninject.Modules;

namespace ExploreLuxury.Presentation.Web.UI
{
    public class NinjectDependencyResolver : IDependencyResolver, IDisposable
    {
        public IKernel kernel;

        public NinjectDependencyResolver()
        {
            // add more ninject module
            var modules = new INinjectModule[]
                              {
                                 new RepositoryModule(), 
                                 new LoggingModule(),
                                 new AccountModule()
                              };

            kernel = new StandardKernel(modules);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public virtual void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDispose)
        {
            if (isDispose)
            {
                kernel.Dispose();
            }
        }
    }
}