using backend.Core.Abstract;
using Microsoft.AspNetCore.SignalR;

namespace backend.Core.Concrete;

public class CommandManager(IHubContext<CommandHub> hub) : ICommands
{
    private readonly IHubContext<CommandHub> _hub = hub;

    public async Task<IResult> Shutdown()
    {
        await _hub.Clients.All.SendAsync("Shutdown");
        
        return Results.Ok("Shutdown initiated.");
    }
}