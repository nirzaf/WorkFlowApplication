using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkFlowApplication.Startup))]
namespace WorkFlowApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
