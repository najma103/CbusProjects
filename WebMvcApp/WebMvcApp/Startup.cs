using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcApp.Startup))]
namespace WebMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
