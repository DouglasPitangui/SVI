using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVI.Startup))]
namespace SVI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
