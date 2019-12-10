using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Socio.Startup))]
namespace Socio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
