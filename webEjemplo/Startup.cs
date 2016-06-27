using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webEjemplo.Startup))]
namespace webEjemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
