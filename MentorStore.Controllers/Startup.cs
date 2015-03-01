using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MentorStore.Controllers.Startup))]
namespace MentorStore.Controllers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
