using Microsoft.AspNetCore.Mvc;
using homepage_backend.Utils;

namespace homepage_backend.Controllers;

[Route("/")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IDbHandler _dbHandler;
    public MessageController(IDbHandler dbHandler)
    {
        _dbHandler = dbHandler;
    }

    [HttpGet("ping/")]
    public Task<string> Ping()
    {
        return Task.FromResult("pong");
    }
}