using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab12a.Startup))]
namespace lab12a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
