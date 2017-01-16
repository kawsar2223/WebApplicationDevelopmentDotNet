using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentResultManagement.Startup))]
namespace StudentResultManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
