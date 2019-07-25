using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsSample.Startup))]
namespace DevOpsSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
