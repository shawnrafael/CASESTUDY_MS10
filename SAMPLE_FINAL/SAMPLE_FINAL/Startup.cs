using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAMPLE_FINAL.Startup))]
namespace SAMPLE_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
