using Microsoft.EntityFrameworkCore.Design;

namespace TodoTemplateDevOps.Server.Api.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseSqlServer(args[1]);

        return new AppDbContext(optionsBuilder.Options);
    }
}
