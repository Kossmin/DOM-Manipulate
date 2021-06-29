using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoChatApp2.Startup))]
namespace DemoChatApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
