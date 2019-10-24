using AutoMapper.Configuration;

namespace JPProject.Admin.Application.AutoMapper
{
    public class AdminUiMapperConfiguration
    {
        public static MapperConfigurationExpression RegisterMappings()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile(new IdentityServer4.EntityFramework.Mappers.ApiResourceMapperProfile());
            cfg.AddProfile(new IdentityServer4.EntityFramework.Mappers.ClientMapperProfile());
            cfg.AddProfile(new IdentityServer4.EntityFramework.Mappers.IdentityResourceMapperProfile());
            cfg.AddProfile(new IdentityServer4.EntityFramework.Mappers.PersistedGrantMapperProfile());
            cfg.AddProfile(new DomainToViewModelMappingProfile());
            cfg.AddProfile(new ViewModelToDomainMappingProfile());

            return cfg;
        }
    }
}
