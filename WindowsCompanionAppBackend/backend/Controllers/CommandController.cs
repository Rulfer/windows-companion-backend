using backend.Core.Abstract;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;


[ApiController]
[Route("[controller]")]
public class CommandController(ICommands commands) : ControllerBase
{
    [HttpPost("shutdown")]
    public async Task<IResult> Shutdown()
    {
        var result = await commands.Shutdown();
        return result;
    }
}