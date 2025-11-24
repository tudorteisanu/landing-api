using Microsoft.AspNetCore.Mvc;
using LandingApi.Models.DTOs;

namespace LandingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHealth()
    {
        return Ok(new HealthResponse { Status = "ok" });
    }
}
