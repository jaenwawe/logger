using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jnFrontEnd.Startup))]
namespace jnFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
