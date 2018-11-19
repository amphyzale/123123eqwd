using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tourist.Startup))]
namespace Tourist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
