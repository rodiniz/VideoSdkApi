using Microsoft.AspNetCore.Mvc;

namespace VideoSdkApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TokenController : ControllerBase
{
    [HttpGet("token")]
    public IActionResult Get()
    {
        return Ok(Helpers.GenerateToken());
    }
}
