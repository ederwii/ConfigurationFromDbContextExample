using Microsoft.AspNetCore.Mvc;

namespace ConfigurationFromDbContextExample.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{
  private readonly IConfiguration _config;
  private readonly ILogger<PingController> _logger;

  public PingController(ILogger<PingController> logger, IConfiguration config)
  {
    _logger = logger;
    _config = config;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var value = _config["quote1"];
    return Ok(value);
  }
}
