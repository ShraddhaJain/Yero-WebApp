using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yero.Startup))]
namespace Yero
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
