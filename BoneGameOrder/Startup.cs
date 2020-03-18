using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoneGameOrder.Startup))]
namespace BoneGameOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
