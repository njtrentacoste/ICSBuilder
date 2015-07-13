using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICSBuilder.Startup))]
namespace ICSBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
