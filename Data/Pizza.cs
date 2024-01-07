using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore.Models
{
  public class Pizza
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
  }

  [Index(nameof(CountryCode))]
  public class Hashtag
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CountryCode { get; set; }
    public int Posts { get; set; }
    public int Rank { get; set; }
    public bool LatestTrending { get; set; }
    public int Views { get; set; }
    public bool IsPromoted { get; set; }
    public int TrendingType { get; set; }
    public DateTime InsertedAt { get; set; }

    // Navigation property for the related hashtag_trend
    // public List<HashtagTrend> HashtagTrend { get; set; }

    // // Index attribute for the country_code column
    // [Index]
    // public string CountryCode { get; set; }
  }
}

class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions options) : base(options) { }
  public DbSet<Pizza> Pizzas { get; set; } = null!;
  public DbSet<Hashtag> Hashtags { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    // Define additional configurations, such as indexes
    modelBuilder.Entity<Hashtag>()
        .Property(h => h.Id)
        .HasDefaultValueSql("gen_random_uuid()");
  }
}