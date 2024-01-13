using BestGarden.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BestGarden.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        string DB_HOST = Environment.GetEnvironmentVariable("DB_HOST") ?? "(localdb)\\MSSQLLocalDB";
        string DB_NAME = Environment.GetEnvironmentVariable("DB_NAME") ?? "BestGarden";
        string DB_PASSWORD = Environment.GetEnvironmentVariable("SA_PASSWORD") ?? "GardenFlower";

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            var con = $"Data source={DB_HOST};" +
                      $"Initial Catalog={DB_NAME};" +
                      $"User ID=SA;Password={DB_PASSWORD};" +
                      $"TrustServerCertificate=True;";
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseLazyLoadingProxies()
                    .UseSqlServer(connectionString);
        });

        //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IBasketItemRepository, BasketItemRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
