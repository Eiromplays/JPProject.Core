using JPProject.Admin.Domain.Commands.ApiResource;

namespace JPProject.Admin.Domain.Validations.ApiResource
{
    public class RegisterApiResourceCommandValidation : ApiResourceValidation<RegisterApiResourceCommand>
    {
        public RegisterApiResourceCommandValidation()
        {
            ValidateName();
        }
    }
}