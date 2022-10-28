using Microsoft.EntityFrameworkCore.Design;

namespace TodoTemplateDevOps.Server.Api.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }

        optionsBuilder.UseSqlServer(args[0]);

        return new AppDbContext(optionsBuilder.Options);
    }
}
