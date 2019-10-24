using JPProject.Admin.Application.Interfaces;
using JPProject.Admin.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JPProject.Admin.Application.Configuration
{
    internal class ApplicationBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPersistedGrantAppService, PersistedGrantAppService>();
            services.AddScoped<IApiResourceAppService, ApiResourceAppService>();
            services.AddScoped<IIdentityResourceAppService, IdentityResourceAppService>();
            services.AddScoped<IScopesAppService, ScopesAppService>();
            services.AddScoped<IClientAppService, ClientAppService>();
        }
    }
}
