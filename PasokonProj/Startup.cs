using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasokonProj.Startup))]
namespace PasokonProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
