using JPProject.Admin.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace JPProject.Admin.Infra.Data.Sqlite.Configuration
{
    public static class DatabaseConfig
    {
        public static IServiceCollection WithSqlite(this IServiceCollection services, string connectionString)
        {
            var migrationsAssembly = typeof(DatabaseConfig).GetTypeInfo().Assembly.GetName().Name;
            services.AddAdminContext(options => options.UseSqlite(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly)));

            return services;
        }

    }
}