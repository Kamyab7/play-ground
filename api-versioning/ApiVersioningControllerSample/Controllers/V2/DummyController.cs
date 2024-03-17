using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningControllerSample.Controllers.V2;

[ApiController]
[Route("api/v{v:apiVersion}/[controller]/[action]")]
[ApiVersion("2.0")]
public class DummyController : ControllerBase
{
    [HttpGet("{name}")]
    public IActionResult SayHello(string name)
    {
        return Ok($"Hello {name}");
    }
}
