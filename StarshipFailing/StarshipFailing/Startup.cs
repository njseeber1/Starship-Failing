using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarshipFailing.Startup))]
namespace StarshipFailing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
