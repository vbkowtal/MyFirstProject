using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialApplication.Startup))]
namespace TutorialApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
