using Microsoft.AspNetCore.Mvc;
using LandingApi.Services;

namespace LandingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialsController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialsController(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTestimonials()
    {
        try
        {
            var testimonials = await _testimonialService.GetTestimonialsAsync();
            return Ok(testimonials);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Internal server error" });
        }
    }
}
