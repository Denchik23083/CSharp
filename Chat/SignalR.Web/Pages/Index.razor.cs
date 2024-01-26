using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Web.Pages
{
    public partial class Index : IAsyncDisposable
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        private HubConnection? _hubConnection;
        private readonly List<string> _messages = new();
        private string? _userInput;
        private string? _messageInput;

        public bool IsConnected => _hubConnection?.State == HubConnectionState.Connected;

        protected override async Task OnInitializedAsync()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
                .Build();

            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var encodedMsg = $"{user}: {message}";
                _messages.Add(encodedMsg);
                InvokeAsync(StateHasChanged);
            });

            await _hubConnection.StartAsync();
        }

        private async Task Send()
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.SendAsync("SendMessage", _userInput, _messageInput);
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.DisposeAsync();
            }
        }
    }
}