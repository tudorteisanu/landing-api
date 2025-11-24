# .NET Landing API

A high-performance RESTful API built with ASP.NET Core 8.0, featuring Entity Framework Core with PostgreSQL integration.

## Features

- ⚡ ASP.NET Core 8.0 Web API
- 🗄️ Entity Framework Core with PostgreSQL
- 📊 Swagger/OpenAPI documentation
- 🐳 Docker support with Docker Compose
- 🔄 CORS enabled
- 📦 Response compression
- 🎯 Clean Architecture with services layer
- ✅ Input validation with Data Annotations

## API Endpoints

All endpoints are prefixed with `/api` except `/health`:

### Landing Page
- `GET /api/landing-page` - Get landing page data (from database)

### Stats
- `GET /api/stats` - Get platform statistics

### Pricing
- `GET /api/pricing` - Get pricing plans

### Testimonials
- `GET /api/testimonials` - Get customer testimonials

### Contact
- `POST /api/contact` - Submit contact form
  ```json
  {
    "name": "John Doe",
    "email": "john@example.com",
    "subject": "Question",
    "message": "Your message here"
  }
  ```

### Health Check
- `GET /health` - Health check endpoint

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- PostgreSQL (or use Docker Compose)

### Installation

1. Clone the repository:
```bash
git clone <repository-url>
cd optimized-landing-dotnet
```

2. Restore dependencies:
```bash
dotnet restore
```

3. Update the connection string in `appsettings.Development.json` if needed.

4. Run the application:
```bash
dotnet run
```

The API will be available at `http://localhost:5050`

### Using Docker Compose

Run the entire stack (API + PostgreSQL):

```bash
docker-compose up -d
```

This will start:
- PostgreSQL on port 5432
- .NET API on port 5050

## Build for Production

```bash
dotnet build -c Release
dotnet publish -c Release -o ./publish
```

## Project Structure

```
LandingApi/
├── Controllers/          # API Controllers
│   ├── ContactController.cs
│   ├── HealthController.cs
│   ├── LandingPageController.cs
│   ├── PricingController.cs
│   ├── StatsController.cs
│   └── TestimonialsController.cs
├── Data/                 # Database context
│   └── LandingDbContext.cs
├── Models/               # Domain models
│   ├── LandingPage.cs
│   └── DTOs/            # Data Transfer Objects
│       ├── Contact.cs
│       ├── HealthResponse.cs
│       ├── LandingPageData.cs
│       ├── PricingPlan.cs
│       ├── Stats.cs
│       └── Testimonial.cs
├── Services/             # Business logic layer
│   ├── ContactService.cs
│   ├── LandingPageService.cs
│   ├── PricingService.cs
│   ├── StatsService.cs
│   └── TestimonialService.cs
├── Program.cs            # Application entry point
├── LandingApi.csproj     # Project file
└── appsettings.json      # Configuration
```

## Configuration

### Database Connection

Configure the PostgreSQL connection in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=landing_db;Username=landing_user;Password=landing_pass"
  }
}
```

### Environment Variables

- `PORT` - Server port (default: 5050)
- `ASPNETCORE_ENVIRONMENT` - Environment (Development/Production)
- `ConnectionStrings__DefaultConnection` - Database connection string

## Swagger Documentation

When running in Development mode, Swagger UI is available at:
- `http://localhost:5050/swagger`

## Docker Deployment

### Build Docker Image

```bash
docker build -t landing-dotnet-api .
```

### Run Container

```bash
docker run -p 5050:5050 \
  -e ConnectionStrings__DefaultConnection="Host=postgres;Port=5432;Database=landing_db;Username=landing_user;Password=landing_pass" \
  landing-dotnet-api
```

## Technologies Used

- **ASP.NET Core 8.0** - Web API framework
- **Entity Framework Core 8.0** - ORM
- **Npgsql** - PostgreSQL provider for EF Core
- **Swashbuckle** - Swagger/OpenAPI documentation
- **Docker** - Containerization

## API Response Examples

### GET /api/landing-page
```json
{
  "seo": {
    "title": "Welcome to Our Platform",
    "description": "Build amazing things with our platform",
    "keywords": "platform, landing page, dotnet",
    "ogTitle": "Welcome to Our Platform",
    "ogDescription": "Build amazing things with our platform",
    "ogImage": "/og-image.jpg"
  },
  "hero": {
    "title": "Build Amazing Things",
    "subtitle": "The best platform for your next project",
    "cta": "Get Started"
  },
  "features": [
    {
      "id": "1",
      "title": "Fast Performance",
      "description": "Lightning-fast load times",
      "icon": "⚡"
    }
  ]
}
```

### GET /api/stats
```json
{
  "users": "10,000+",
  "projects": "50,000+",
  "uptime": "99.9%",
  "countries": "150+"
}
```

### GET /health
```json
{
  "status": "ok"
}
```

## Migration from Node.js

This is a .NET port of the original Node.js Express API. Key differences:

- Uses ASP.NET Core instead of Express
- Entity Framework Core instead of direct PostgreSQL driver
- Built-in dependency injection
- Strongly typed with C#
- Swagger documentation out of the box
- Similar endpoint structure and responses

Both versions maintain API compatibility and can be used interchangeably.

## Performance Features

- Asynchronous operations throughout
- Response compression enabled
- Connection pooling with EF Core
- Optimized database queries
- Minimal memory allocation

## License

MIT
