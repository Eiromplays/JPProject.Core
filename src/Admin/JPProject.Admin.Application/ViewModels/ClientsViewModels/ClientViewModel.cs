using IdentityServer4.Models;
using Newtonsoft.Json;

namespace JPProject.Admin.Application.ViewModels.ClientsViewModels
{
    public class ClientViewModel : Client
    {
        [JsonIgnore]
        public string OldClientId { get; set; }
    }
}
