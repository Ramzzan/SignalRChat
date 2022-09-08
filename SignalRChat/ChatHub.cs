using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public async Task SendMessage (string message, string user)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, user);
        }
    }
}
