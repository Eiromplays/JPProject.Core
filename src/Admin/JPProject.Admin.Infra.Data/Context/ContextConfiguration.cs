using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JPProject.Admin.Infra.Data.Context
{
    public static class ContextConfiguration
    {
        public static IServiceCollection AddAdminContext(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction)
        {
            var operationalStoreOptions = new OperationalStoreOptions();
            services.AddSingleton(operationalStoreOptions);

            var storeOptions = new ConfigurationStoreOptions();
            services.AddSingleton(storeOptions);

            services.AddDbContext<IdentityServerContext>(optionsAction);
            services.AddDbContext<EventStoreContext>(optionsAction);

            return services;
        }
    }
}
