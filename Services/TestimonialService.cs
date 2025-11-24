using LandingApi.Models.DTOs;

namespace LandingApi.Services;

public interface ITestimonialService
{
    Task<List<Testimonial>> GetTestimonialsAsync();
}

public class TestimonialService : ITestimonialService
{
    public async Task<List<Testimonial>> GetTestimonialsAsync()
    {
        // Simulate async delay
        await Task.Delay(300);

        return new List<Testimonial>
        {
            new Testimonial
            {
                Id = 1,
                Name = "John Doe",
                Role = "CEO at TechCorp",
                Content = "This platform transformed our business. Highly recommended!",
                Avatar = "👨‍💼",
                Rating = 5
            },
            new Testimonial
            {
                Id = 2,
                Name = "Jane Smith",
                Role = "Product Manager",
                Content = "Best decision we made this year. The ROI is incredible.",
                Avatar = "👩‍💼",
                Rating = 5
            },
            new Testimonial
            {
                Id = 3,
                Name = "Mike Johnson",
                Role = "Developer",
                Content = "Easy to integrate and great documentation. Love it!",
                Avatar = "👨‍💻",
                Rating = 5
            }
        };
    }
}
