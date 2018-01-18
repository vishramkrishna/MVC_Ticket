using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eticket.Startup))]
namespace Eticket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
