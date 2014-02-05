using ExploreLuxury.Infrastructure.Interfaces;
using ExploreLuxury.Infrastructure.Logging;
using Ninject.Modules;

namespace ExploreLuxury.Infrastructure.DependencyResolution
{
    public class LoggingModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<ILoggingService>().To<Log4NetLoggerService>();
        }
    }
}
