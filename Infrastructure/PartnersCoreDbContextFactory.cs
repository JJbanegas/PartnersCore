using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure;

public class PartnersCoreDbContextFactory : IDesignTimeDbContextFactory<PartnersCoreDbContext>
{
    public PartnersCoreDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PartnersCoreDbContext>();
        optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("VidarConnectionString"));

        return new PartnersCoreDbContext(optionsBuilder.Options);
    }
}