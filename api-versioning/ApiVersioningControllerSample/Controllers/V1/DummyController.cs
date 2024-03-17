using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningControllerSample.Controllers.V1;

[ApiController]
[Route("api/v{v:apiVersion}/[controller]/[action]")]
[ApiVersion("1.0")]
public class DummyController : ControllerBase
{
    [HttpGet]
    public IActionResult SayHello()
    {
        return Ok("Hello");
    }
}
