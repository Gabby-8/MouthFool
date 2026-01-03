using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new {message = "Hello from .Net backend"});
    }
}