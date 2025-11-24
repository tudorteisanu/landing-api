namespace LandingApi.Models;

public class LandingPage
{
    public int Id { get; set; }
    public string Data { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
