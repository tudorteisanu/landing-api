namespace LandingApi.Models.DTOs;

public class PricingPlan
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public List<string> Features { get; set; } = new();
    public bool Highlighted { get; set; }
}
