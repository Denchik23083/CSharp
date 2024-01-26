using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.Auth.Hubs
{
    //[Authorize]
    public class NotificationsHub : Hub<INotificationClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).ReceiveNotification(
                $"{Context.User?.Identity?.Name} Connected!");

            await base.OnConnectedAsync();
        }
    }
}
