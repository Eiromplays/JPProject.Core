using System.ComponentModel.DataAnnotations;

namespace JPProject.Admin.Application.ViewModels.ApiResouceViewModels
{
    public class RemoveApiScopeViewModel
    {
        public RemoveApiScopeViewModel(string resourceName, string name)
        {
            ResourceName = resourceName;
            Name = name;
        }

        [Required]
        public string ResourceName { get; set; }

        [Required]
        public string Name { get; set; }
    }
}