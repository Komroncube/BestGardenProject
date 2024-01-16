using System.Reflection;
using BestGarden.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BestGarden.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddTransient<IFileService, FileService>();
        return services;
    }
    
}