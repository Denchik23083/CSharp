using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Web.Pages
{
    public partial class Index : IAsyncDisposable
    {
        private HubConnection? _hubConnection;
        private readonly List<string> _messages = new();

        protected override async Task OnInitializedAsync()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImY0NWZlNDc1LTg0NjYtNDg0Zi1hZjY5LWEyNjU4YThlZTkxNSIsInN1YiI6ImY0NWZlNDc1LTg0NjYtNDg0Zi1hZjY5LWEyNjU4YThlZTkxNSIsImp0aSI6IjM1NjM3M2ZlIiwiYXVkIjpbImh0dHA6Ly9sb2NhbGhvc3Q6NjE4MzgiLCJodHRwczovL2xvY2FsaG9zdDo0NDM4MSIsImh0dHBzOi8vbG9jYWxob3N0OjUwMDEiLCJodHRwOi8vbG9jYWxob3N0OjUwMDAiXSwibmJmIjoxNzA2Mjg3OTI0LCJleHAiOjE3MTQxNTAzMjQsImlhdCI6MTcwNjI4NzkyNywiaXNzIjoiZG90bmV0LXVzZXItand0cyJ9.GManEbkRfIJ2eZwuh5YD5EDiUKahYpl9xGhGVWaMU0E";

            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/notifications",
                _ => _.AccessTokenProvider = () => Task.FromResult<string?>(token))
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
