using Microsoft.AspNetCore.SignalR;

namespace SignalR.Api
{
    public sealed class ChatHub : Hub<IChatClint>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} has joind");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} : {message}");
        }
    }
}
