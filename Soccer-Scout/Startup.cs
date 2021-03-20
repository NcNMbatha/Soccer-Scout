using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soccer_Scout.Startup))]
namespace Soccer_Scout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
