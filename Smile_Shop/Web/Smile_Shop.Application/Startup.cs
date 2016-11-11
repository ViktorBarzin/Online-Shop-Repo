using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smile_Shop.Application.Startup))]
namespace Smile_Shop.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
