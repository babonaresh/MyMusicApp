using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMusicApp.Startup))]
namespace MyMusicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
