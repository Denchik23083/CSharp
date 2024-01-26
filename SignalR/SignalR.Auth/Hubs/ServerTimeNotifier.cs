using Microsoft.AspNetCore.SignalR;

namespace SignalR.Auth.Hubs
{
    public class ServerTimeNotifier : BackgroundService
    {
        private static readonly TimeSpan Period = TimeSpan.FromSeconds(10);
        private readonly ILogger<ServerTimeNotifier> _logger;
        private readonly IHubContext<NotificationsHub, INotificationClient> _context;

        public ServerTimeNotifier(ILogger<ServerTimeNotifier> logger, IHubContext<NotificationsHub, INotificationClient> context)
        {
            _logger = logger;
            _context = context;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var timer = new PeriodicTimer(Period);

            while (!stoppingToken.IsCancellationRequested
                && await timer.WaitForNextTickAsync(stoppingToken))
            {
                var dateTime = DateTime.Now;

                _logger.LogInformation("Executing {Sevice} {Time}", nameof(ServerTimeNotifier), dateTime);

                await _context.Clients
                    //.User("f45fe475-8466-484f-af69-a2658a8ee915")
                    .All
                    .ReceiveNotification($"Server time = {dateTime}");
            }
        }
    }
}
