using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChatWeb.Startup))]
namespace SignalRChatWeb
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
