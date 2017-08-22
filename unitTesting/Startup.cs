using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unitTesting.Startup))]
namespace unitTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
