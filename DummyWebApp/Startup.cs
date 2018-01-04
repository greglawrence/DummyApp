using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DummyWebApp.Startup))]
namespace DummyWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
