using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_With_ViewModalI_InMVC.Startup))]
namespace CRUD_With_ViewModalI_InMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
