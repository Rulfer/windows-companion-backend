namespace backend.Core.Abstract;

public interface ICommands
{
    public Task<IResult> Shutdown();
}