using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExploreGlobal.Presentation.Web.UI.Startup))]
namespace ExploreGlobal.Presentation.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
