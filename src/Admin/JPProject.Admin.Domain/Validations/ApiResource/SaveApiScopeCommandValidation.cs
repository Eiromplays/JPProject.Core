using JPProject.Admin.Domain.Commands.ApiResource;

namespace JPProject.Admin.Domain.Validations.ApiResource
{
    public class SaveApiScopeCommandValidation : ApiScopeValidation<SaveApiScopeCommand>
    {
        public SaveApiScopeCommandValidation()
        {
            ValidateResourceName();
        }
    }
}