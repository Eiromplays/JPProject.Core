using JPProject.Admin.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DatabaseConfig
    {
        public static IServiceCollection WithMySql(this IServiceCollection services, string connectionString)
        {
            var migrationsAssembly = typeof(DatabaseConfig).GetTypeInfo().Assembly.GetName().Name;
            services.AddAdminContext(options => options.UseMySql(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly)));

            return services;
        }
    }
}