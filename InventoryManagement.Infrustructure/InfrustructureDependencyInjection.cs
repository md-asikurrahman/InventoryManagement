using InventoryManagement.Infrustructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace InventoryManagement.Infrustructure
{
    public static class InfrustructureDependencyInjection
    {
        public static IServiceCollection AddInfrustructureDependency(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            });
            return services;
        }
    }
}
