using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RejestrLog.Startup))]
namespace RejestrLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
