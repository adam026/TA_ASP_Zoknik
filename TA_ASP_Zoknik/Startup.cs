using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TA_ASP_Zoknik.Startup))]
namespace TA_ASP_Zoknik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
