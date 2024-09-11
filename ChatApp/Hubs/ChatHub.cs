
using ChatApp.Services;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    private readonly OllamaService _ollamaService;

    public ChatHub(OllamaService ollamaService)
    {
        _ollamaService = ollamaService;
    }

    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);

        string response = await _ollamaService.GetResponseFromOllama(message);

        await Clients.All.SendAsync("ReceiveMessage", "CrewAI Agent", response);
    }
}
