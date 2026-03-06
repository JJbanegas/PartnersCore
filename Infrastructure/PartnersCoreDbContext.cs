using Domain;
using Infrastructure.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class PartnersCoreDbContext(DbContextOptions<PartnersCoreDbContext> options) : DbContext(options)
{
    private const Microsoft.Extensions.Logging.LogLevel LogLevel = Microsoft.Extensions.Logging.LogLevel.Information;
    public DbSet<Partner> Partners { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies()
            .LogTo(Console.WriteLine, LogLevel);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        base.OnModelCreating(modelBuilder);
        
        ConfigurePartnerEntity(modelBuilder);
    }
    
    private static void ConfigurePartnerEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PartnerEntityConfiguration());
    }
}