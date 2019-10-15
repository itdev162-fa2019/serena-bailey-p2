using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : DbContext
  {
    public DbSet<Value> Values { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Value>().HasData(
        new Value { Id = 1, Name = "SailorMoon" },
        new Value { Id = 2, Name = "MadokaMagica" },
        new Value { Id = 3, Name = "CardCaptorSakura" }
      );
    }
  }
}