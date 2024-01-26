namespace SignalR.Auth.Hubs
{
    public interface INotificationClient
    {
        Task ReceiveNotification(string message);
    }
}
