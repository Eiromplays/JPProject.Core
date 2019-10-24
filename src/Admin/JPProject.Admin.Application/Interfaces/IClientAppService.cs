using IdentityServer4.Models;
using JPProject.Admin.Application.ViewModels;
using JPProject.Admin.Application.ViewModels.ClientsViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPProject.Admin.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        Task<IEnumerable<ClientListViewModel>> GetClients();
        Task<Client> GetClientDetails(string clientId);
        Task Update(string id, Client client);
        Task<IEnumerable<SecretViewModel>> GetSecrets(string clientId);
        Task RemoveSecret(RemoveClientSecretViewModel model);
        Task SaveSecret(SaveClientSecretViewModel model);
        Task<IEnumerable<ClientPropertyViewModel>> GetProperties(string clientId);
        Task RemoveProperty(RemovePropertyViewModel model);
        Task SaveProperty(SaveClientPropertyViewModel model);
        Task<IEnumerable<ClaimViewModel>> GetClaims(string clientId);
        Task RemoveClaim(RemoveClientClaimViewModel model);
        Task SaveClaim(SaveClientClaimViewModel model);
        //Task Save(SaveClientViewModel client);
        Task Save(SaveClientViewModel client);
        Task Remove(RemoveClientViewModel client);
        Task Copy(CopyClientViewModel client);
        Task<Client> GetClientDefaultDetails(string clientId);
    }
}