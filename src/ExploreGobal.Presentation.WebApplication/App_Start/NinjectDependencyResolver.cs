using ExploreGlobal.Infrastructure.DependencyResolution;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExploreGobal.Presentation.UI.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver 
    {
        public IKernel kernel;

        public NinjectDependencyResolver()
        {
            // add more ninject module
            var modules = new INinjectModule[]
                              {
                                 new RepositoryModule(), 
                                 new LoggingModule()
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
    }
}