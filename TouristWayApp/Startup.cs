using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TouristWayApp.Startup))]
namespace TouristWayApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
