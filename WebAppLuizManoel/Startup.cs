using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppLuizManoel.Startup))]
namespace WebAppLuizManoel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
