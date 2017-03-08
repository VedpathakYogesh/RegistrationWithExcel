using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DptsData.Startup))]
namespace DptsData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
