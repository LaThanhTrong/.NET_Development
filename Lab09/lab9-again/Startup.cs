using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab9_again.Startup))]
namespace lab9_again
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
