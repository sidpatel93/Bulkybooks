using Microsoft.EntityFrameworkCore;

namespace BulkyBooks.Data
{
  public class ApplicationDBContext : DbContext
  {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
    {
      
    }
    // Add your DbSet properties here

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // Configure your database connection here
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Configure your entity mappings here
    }
  }
}