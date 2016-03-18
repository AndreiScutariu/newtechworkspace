using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRChatWeb.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        [HubMethodName("onNewMessage")]
        public void Send(string message)
        {
            Clients.All.onNewMessage(message);
        }
    }
}