using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRentalShopWep.Startup))]
namespace VideoRentalShopWep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
