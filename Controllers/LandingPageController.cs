using Microsoft.AspNetCore.Mvc;
using LandingApi.Services;

namespace LandingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LandingPageController : ControllerBase
{
    private readonly ILandingPageService _landingPageService;

    public LandingPageController(ILandingPageService landingPageService)
    {
        _landingPageService = landingPageService;
    }

    [HttpGet]
    public async Task<IActionResult> GetLandingPage()
    {
        var data = await _landingPageService.GetLandingPageDataAsync();

        if (data == null)
        {
            return NotFound(new { message = "No data found" });
        }

        return Ok(data);
    }
}
