using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcpractice.Startup))]
namespace mvcpractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
