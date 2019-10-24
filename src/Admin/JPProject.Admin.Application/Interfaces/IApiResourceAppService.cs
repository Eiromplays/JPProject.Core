using IdentityServer4.Models;
using JPProject.Admin.Application.ViewModels;
using JPProject.Admin.Application.ViewModels.ApiResouceViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPProject.Admin.Application.Interfaces
{
    public interface IApiResourceAppService : IDisposable
    {
        Task<IEnumerable<ApiResourceListViewModel>> GetApiResources();
        Task<ApiResource> GetDetails(string name);
        Task Save(ApiResource model);
        Task Update(string id, ApiResource model);
        Task Remove(RemoveApiResourceViewModel model);
        Task<IEnumerable<SecretViewModel>> GetSecrets(string name);
        Task RemoveSecret(RemoveApiSecretViewModel model);
        Task SaveSecret(SaveApiSecretViewModel model);
        Task<IEnumerable<ScopeViewModel>> GetScopes(string name);
        Task RemoveScope(RemoveApiScopeViewModel model);
        Task SaveScope(SaveApiScopeViewModel model);
    }
}