using backend.Core.Abstract;

namespace backend.Core.Concrete;

public class CommandManager: ICommands
{
    public async Task<IResult> Shutdown()
    {
        return Results.Ok("Shutdown initiated.");
    }
}