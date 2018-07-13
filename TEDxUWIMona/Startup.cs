using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEDxUWIMona.Startup))]
namespace TEDxUWIMona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
