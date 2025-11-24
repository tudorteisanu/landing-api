using LandingApi.Data;
using LandingApi.Models;
using LandingApi.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace LandingApi.Services;

public interface ILandingPageService
{
    Task<LandingPageData?> GetLandingPageDataAsync();
    Task InitializeDatabaseAsync();
}

public class LandingPageService : ILandingPageService
{
    private readonly LandingDbContext _context;
    private readonly ILogger<LandingPageService> _logger;

    public LandingPageService(LandingDbContext context, ILogger<LandingPageService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task InitializeDatabaseAsync()
    {
        try
        {
            await _context.Database.EnsureCreatedAsync();

            var count = await _context.LandingPages.CountAsync();

            if (count == 0)
            {
                var defaultData = new LandingPageData
                {
                    Seo = new SeoData
                    {
                        Title = "Welcome to Our Platform",
                        Description = "Build amazing things with our platform",
                        Keywords = "platform, landing page, dotnet",
                        OgTitle = "Welcome to Our Platform",
                        OgDescription = "Build amazing things with our platform",
                        OgImage = "/og-image.jpg"
                    },
                    Hero = new HeroData
                    {
                        Title = "Build Amazing Things",
                        Subtitle = "The best platform for your next project",
                        Cta = "Get Started"
                    },
                    Features = new List<Feature>
                    {
                        new Feature
                        {
                            Id = "1",
                            Title = "Fast Performance",
                            Description = "Lightning-fast load times with optimized APIs",
                            Icon = "⚡"
                        },
                        new Feature
                        {
                            Id = "2",
                            Title = "SEO Optimized",
                            Description = "Built-in SEO best practices",
                            Icon = "🎯"
                        },
                        new Feature
                        {
                            Id = "3",
                            Title = "Easy to Use",
                            Description = "Simple and intuitive interface",
                            Icon = "✨"
                        }
                    }
                };

                var landingPage = new LandingPage
                {
                    Data = JsonSerializer.Serialize(defaultData),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                _context.LandingPages.Add(landingPage);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Default landing page data inserted");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Database initialization error");
        }
    }

    public async Task<LandingPageData?> GetLandingPageDataAsync()
    {
        var landingPage = await _context.LandingPages
            .OrderByDescending(lp => lp.Id)
            .FirstOrDefaultAsync();

        if (landingPage == null)
        {
            return null;
        }

        return JsonSerializer.Deserialize<LandingPageData>(landingPage.Data);
    }
}
