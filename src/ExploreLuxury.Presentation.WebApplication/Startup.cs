using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExploreGobal.Presentation.UI.App_Start.Startup))]
namespace ExploreGobal.Presentation.UI.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
