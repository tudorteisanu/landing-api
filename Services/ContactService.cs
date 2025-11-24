using LandingApi.Models.DTOs;

namespace LandingApi.Services;

public interface IContactService
{
    Task<ContactResponse> SubmitContactFormAsync(ContactRequest request);
}

public class ContactService : IContactService
{
    private readonly ILogger<ContactService> _logger;

    public ContactService(ILogger<ContactService> logger)
    {
        _logger = logger;
    }

    public async Task<ContactResponse> SubmitContactFormAsync(ContactRequest request)
    {
        // Simulate async delay
        await Task.Delay(500);

        _logger.LogInformation("Contact form submission: Name={Name}, Email={Email}, Subject={Subject}, Message={Message}",
            request.Name, request.Email, request.Subject, request.Message);

        return new ContactResponse
        {
            Success = true,
            Message = "Thank you for contacting us!"
        };
    }
}
