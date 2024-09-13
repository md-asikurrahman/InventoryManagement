using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependency(this IServiceCollection services)
        {


            return services;
        }
    }
}
