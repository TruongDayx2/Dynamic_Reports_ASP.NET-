using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(N19DCCN218_Report.Startup))]
namespace N19DCCN218_Report
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
