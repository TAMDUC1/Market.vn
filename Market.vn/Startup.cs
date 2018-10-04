using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Market.vn.Startup))]
namespace Market.vn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
