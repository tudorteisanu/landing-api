using Microsoft.AspNetCore.Mvc;
using LandingApi.Services;

namespace LandingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PricingController : ControllerBase
{
    private readonly IPricingService _pricingService;

    public PricingController(IPricingService pricingService)
    {
        _pricingService = pricingService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPricing()
    {
        try
        {
            var pricing = await _pricingService.GetPricingPlansAsync();
            return Ok(pricing);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Internal server error" });
        }
    }
}
