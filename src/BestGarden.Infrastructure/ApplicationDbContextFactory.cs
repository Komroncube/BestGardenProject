using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BestGarden.Infrastructure;
internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        var connectionString = configuration.GetConnectionString("PostgresqlConnection");

        builder.UseNpgsql(connectionString);

        return new ApplicationDbContext(builder.Options);
    }
    // database connection string || used for docker-compose
    private static string GetConnectionString()
    {
        string DB_HOST = Environment.GetEnvironmentVariable("DB_HOST") ?? "(localdb)\\MSSQLLocalDB";
        string DB_NAME = Environment.GetEnvironmentVariable("DB_NAME") ?? "BestGardenProjectDB";
        string DB_PASSWORD = Environment.GetEnvironmentVariable("SA_PASSWORD") ?? "GardenFlower";

        var con = $"Data source={DB_HOST};" +
                  $"Initial Catalog={DB_NAME};" +
                  $"User ID=SA;Password={DB_PASSWORD};" +
                  $"TrustServerCertificate=True;";
        return con;
    }
}
