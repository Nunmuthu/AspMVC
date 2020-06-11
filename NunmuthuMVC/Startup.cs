using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NunmuthuMVC.Startup))]
namespace NunmuthuMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
