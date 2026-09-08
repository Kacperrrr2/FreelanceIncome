using FreelanceIncome.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelanceIncome.Api;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DatabaseConnection");
        services.AddDbContext<FreelanceIncomeDbContext>(options => { options.UseNpgsql(connectionString); });
        return services;
    }
}