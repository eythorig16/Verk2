using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GogleDogs.Startup))]
namespace GogleDogs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
