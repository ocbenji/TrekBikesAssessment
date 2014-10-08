using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrekBikesTest.Startup))]
namespace TrekBikesTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
