using System.ComponentModel.DataAnnotations;

namespace LandingApi.Models.DTOs;

public class ContactRequest
{
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    public string? Subject { get; set; }
    
    [Required]
    public string Message { get; set; } = string.Empty;
}

public class ContactResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
