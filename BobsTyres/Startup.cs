using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BobsTyres.Startup))]
namespace BobsTyres
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
