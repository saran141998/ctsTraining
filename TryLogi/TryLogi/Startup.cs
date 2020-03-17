using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryLogi.Startup))]
namespace TryLogi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
