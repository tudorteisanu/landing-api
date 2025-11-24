using LandingApi.Models.DTOs;

namespace LandingApi.Services;

public interface IPricingService
{
    Task<List<PricingPlan>> GetPricingPlansAsync();
}

public class PricingService : IPricingService
{
    public async Task<List<PricingPlan>> GetPricingPlansAsync()
    {
        // Simulate async delay
        await Task.Delay(200);

        return new List<PricingPlan>
        {
            new PricingPlan
            {
                Id = 1,
                Name = "Starter",
                Price = "$29",
                Period = "/month",
                Features = new List<string>
                {
                    "5 Projects",
                    "10 GB Storage",
                    "Email Support",
                    "Basic Analytics"
                },
                Highlighted = false
            },
            new PricingPlan
            {
                Id = 2,
                Name = "Professional",
                Price = "$79",
                Period = "/month",
                Features = new List<string>
                {
                    "Unlimited Projects",
                    "100 GB Storage",
                    "Priority Support",
                    "Advanced Analytics",
                    "Custom Domain"
                },
                Highlighted = true
            },
            new PricingPlan
            {
                Id = 3,
                Name = "Enterprise",
                Price = "$199",
                Period = "/month",
                Features = new List<string>
                {
                    "Unlimited Everything",
                    "Dedicated Support",
                    "Custom Integrations",
                    "SLA Guarantee",
                    "Onboarding"
                },
                Highlighted = false
            }
        };
    }
}
