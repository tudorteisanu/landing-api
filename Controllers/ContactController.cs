using Microsoft.AspNetCore.Mvc;
using LandingApi.Models.DTOs;
using LandingApi.Services;

namespace LandingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpPost]
    public async Task<IActionResult> SubmitContact([FromBody] ContactRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = "All fields are required" });
        }

        try
        {
            var response = await _contactService.SubmitContactFormAsync(request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Internal server error" });
        }
    }
}
