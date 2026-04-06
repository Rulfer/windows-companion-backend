using Microsoft.AspNetCore.SignalR;

namespace backend.Core.Concrete;

public class CommandHub: Hub
{
    private static readonly Dictionary<string, string> _clients = new();
    
    public Task Register(string clientId)
    {
        _clients[clientId] = Context.ConnectionId;
        return Task.CompletedTask;
    }
    
    public static string? GetConnectionId(string clientId)
    {
        _clients.TryGetValue(clientId, out var connId);
        return connId;
    }
}