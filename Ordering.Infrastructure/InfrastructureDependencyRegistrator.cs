using Microsoft.Extensions.DependencyInjection;
using Ordering.Infrastructure.Repositories;
using Ordering.Infrastructure.Repositories.Interfaces;

namespace Ordering.Infrastructure;

public static class InfrastructureDependencyRegistrator
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        #region Repositories registration
        services.AddScoped<IOrdersRepository, OrdersRepository>();
        #endregion

        #region DataProviders registration
        #endregion
    }
}
