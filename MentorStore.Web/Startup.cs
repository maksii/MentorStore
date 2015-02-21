using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MentorStore.Web.Startup))]
namespace MentorStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
