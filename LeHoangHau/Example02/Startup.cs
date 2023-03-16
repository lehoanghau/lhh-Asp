using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Example02.Startup))]
namespace Example02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
