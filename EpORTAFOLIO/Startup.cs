using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EpORTAFOLIO.Startup))]
namespace EpORTAFOLIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
