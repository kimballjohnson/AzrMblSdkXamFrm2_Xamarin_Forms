using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AzrMblSdkXamFrm2Service.Startup))]

namespace AzrMblSdkXamFrm2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}