using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnBridge.Startup))]
namespace LearnBridge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
