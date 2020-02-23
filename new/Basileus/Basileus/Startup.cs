using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Basileus.Startup))]
namespace Basileus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
