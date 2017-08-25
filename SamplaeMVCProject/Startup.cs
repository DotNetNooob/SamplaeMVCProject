using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamplaeMVCProject.Startup))]
namespace SamplaeMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
