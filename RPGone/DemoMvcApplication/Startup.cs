using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMvcApplication.Startup))]
namespace DemoMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
