using LandingApi.Models.DTOs;

namespace LandingApi.Services;

public interface IStatsService
{
    Task<Stats> GetStatsAsync();
}

public class StatsService : IStatsService
{
    public async Task<Stats> GetStatsAsync()
    {
        // Simulate async delay
        await Task.Delay(150);

        return new Stats
        {
            Users = "10,000+",
            Projects = "50,000+",
            Uptime = "99.9%",
            Countries = "150+"
        };
    }
}
