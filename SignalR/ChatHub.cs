using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public class ChatHub : Hub
{
    public async Task Send(string message)
    {
        await Clients.All.SendAsync("Receive", message);
    }
}