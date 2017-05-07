using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5UserRoles.Startup))]
namespace Mvc5UserRoles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
