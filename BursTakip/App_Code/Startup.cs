using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BursTakip.Startup))]
namespace BursTakip
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
