using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLX.Startup))]
namespace OLX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
