using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcSecurity.Startup))]
namespace mvcSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
