using BlogApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    // private readonly TokenService _tokenService;
    // public AccountController(TokenService tokenService)
    // {
    //     _tokenService = tokenService;
    // }

    [HttpPost("v1/login")]
    public IActionResult Login([FromServices] TokenService tokenService)
    {
        var token = tokenService.GenerateToken(null);

        return Ok(token);
    }
}