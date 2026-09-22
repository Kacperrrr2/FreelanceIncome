using FreelanceIncome.Application.Interfaces;
using FreelanceIncome.Infrastructure.Entities;
using FreelanceIncome.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FreelanceIncome.Api;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DatabaseConnection");
        services.AddDbContext<FreelanceIncomeDbContext>(options => { options.UseNpgsql(connectionString); });
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        return services;
    }
}