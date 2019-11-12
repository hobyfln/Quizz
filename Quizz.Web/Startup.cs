using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quizz.Web.Startup))]
namespace Quizz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
