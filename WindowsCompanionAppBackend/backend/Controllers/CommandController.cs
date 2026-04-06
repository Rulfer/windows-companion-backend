using backend.Core.Abstract;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;


[ApiController]
[Route("[controller]")]
public class CommandController: ControllerBase
{
    private readonly ICommands _commands;

    public CommandController(ICommands commands)
    {
        _commands = commands;
    }
    
    [HttpPost("shutdown")]
    public IResult Shutdown()
    {
        var result = _commands.Shutdown();
        return result.Result;
    }
}