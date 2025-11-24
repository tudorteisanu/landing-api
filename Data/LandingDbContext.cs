using Microsoft.EntityFrameworkCore;
using LandingApi.Models;

namespace LandingApi.Data;

public class LandingDbContext : DbContext
{
    public LandingDbContext(DbContextOptions<LandingDbContext> options)
        : base(options)
    {
    }

    public DbSet<LandingPage> LandingPages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LandingPage>(entity =>
        {
            entity.ToTable("landing_page");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data").HasColumnType("jsonb");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });
    }
}
