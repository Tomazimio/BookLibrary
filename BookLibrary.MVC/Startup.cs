using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookLibrary.MVC.Startup))]
namespace BookLibrary.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
