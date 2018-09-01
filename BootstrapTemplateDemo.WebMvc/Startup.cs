using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapTemplateDemo.WebMvc.Startup))]
namespace BootstrapTemplateDemo.WebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
