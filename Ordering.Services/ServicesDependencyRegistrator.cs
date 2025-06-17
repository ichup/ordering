using Microsoft.Extensions.DependencyInjection;
using Ordering.Services.Interfaces;

namespace Ordering.Services;

public static class ServicesDependencyRegistrator
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderHistoryService, OrderHistoryService>();
    }
}
