using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsWebApplication.Startup))]
namespace StudentsWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
