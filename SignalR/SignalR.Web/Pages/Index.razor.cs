using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Web.Pages
{
    public partial class Index : IAsyncDisposable
    {
        private HubConnection? _hubConnection;
        private readonly List<string> _messages = new();

        protected override async Task OnInitializedAsync()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/notifications"/*,
                _ => _.AccessTokenProvider = () => Task.FromResult<string?>("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImY0NWZlNDc1LTg0NjYtNDg0Zi1hZjY5LWEyNjU4YThlZTkxNSIsInN1YiI6ImY0NWZlNDc1LTg0NjYtNDg0Zi1hZjY5LWEyNjU4YThlZTkxNSIsImp0aSI6ImFmMjBlYjNhIiwiYXVkIjpbImh0dHA6Ly9sb2NhbGhvc3Q6NjE4MzgiLCJodHRwczovL2xvY2FsaG9zdDo0NDM4MSIsImh0dHBzOi8vbG9jYWxob3N0OjUwMDEiLCJodHRwOi8vbG9jYWxob3N0OjUwMDAiXSwibmJmIjoxNzA2Mjg0ODU0LCJleHAiOjE3MTQxNDcyNTQsImlhdCI6MTcwNjI4NDg1OCwiaXNzIjoiZG90bmV0LXVzZXItand0cyJ9._a-PvpZPj-rV1LKQjpC2hiFcCup7PdYcrcvo9-A65HI")*/)
                .Build();

            _hubConnection.On<string>("ReceiveNotification", message =>
            {
                _messages.Add(message);

                InvokeAsync(StateHasChanged);
            });

            await _hubConnection.StartAsync();
        }

        public async ValueTask DisposeAsync()
        {
            if(_hubConnection is not null)
            {
                await _hubConnection.DisposeAsync();
            }
        }
    }
}
