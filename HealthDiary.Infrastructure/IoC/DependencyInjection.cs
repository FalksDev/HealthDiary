using HealthDiary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace HealthDiary.Infrastructure.IoC;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDBContext>(opts =>
        {
            opts.UseSqlite(configuration.GetConnectionString("test_db"), 
                b => b.MigrationsAssembly("HealthDiary.Web"));
        });
    }
}