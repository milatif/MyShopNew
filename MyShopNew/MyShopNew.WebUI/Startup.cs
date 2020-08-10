using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopNew.WebUI.Startup))]
namespace MyShopNew.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
