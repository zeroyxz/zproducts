using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zproducts.Startup))]
namespace zproducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
