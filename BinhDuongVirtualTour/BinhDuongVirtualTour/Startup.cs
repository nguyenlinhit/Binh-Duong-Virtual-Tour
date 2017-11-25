using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinhDuongVirtualTour.Startup))]
namespace BinhDuongVirtualTour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
