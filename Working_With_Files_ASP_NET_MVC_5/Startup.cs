using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Working_With_Files_ASP_NET_MVC_5.Startup))]
namespace Working_With_Files_ASP_NET_MVC_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
