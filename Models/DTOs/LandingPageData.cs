namespace LandingApi.Models.DTOs;

public class SeoData
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Keywords { get; set; } = string.Empty;
    public string OgTitle { get; set; } = string.Empty;
    public string OgDescription { get; set; } = string.Empty;
    public string OgImage { get; set; } = string.Empty;
}

public class HeroData
{
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Cta { get; set; } = string.Empty;
}

public class Feature
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}

public class LandingPageData
{
    public SeoData Seo { get; set; } = new();
    public HeroData Hero { get; set; } = new();
    public List<Feature> Features { get; set; } = new();
}
