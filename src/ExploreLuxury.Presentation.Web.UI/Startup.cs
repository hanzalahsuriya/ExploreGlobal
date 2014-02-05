using ExploreLuxury.Presentation.Web.UI;
using Microsoft.Owin;
using Owin;


namespace ExploreLuxury.Presentation.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
