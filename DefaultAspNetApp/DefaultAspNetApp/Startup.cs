using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultAspNetApp.Startup))]
namespace DefaultAspNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
