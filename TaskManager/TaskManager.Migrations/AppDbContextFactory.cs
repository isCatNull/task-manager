using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TaskManager.Infrastructure;

namespace TaskManager.Migrations;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(
            "Host=localhost;Database=TaskManagerDb;Username=admin;Password=dev123",
            b => b.MigrationsAssembly("TaskManager.Migrations") // 👈 point here
        );

        return new AppDbContext(optionsBuilder.Options);
    }
}