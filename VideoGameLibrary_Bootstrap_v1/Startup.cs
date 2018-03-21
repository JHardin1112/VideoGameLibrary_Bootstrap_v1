using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoGameLibrary_Bootstrap_v1.Startup))]
namespace VideoGameLibrary_Bootstrap_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
