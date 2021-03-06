using JPProject.Admin.Domain.Validations.IdentityResource;

namespace JPProject.Admin.Domain.Commands.IdentityResource
{
    public class RegisterIdentityResourceCommand : IdentityResourceCommand
    {

        public RegisterIdentityResourceCommand(IdentityServer4.Models.IdentityResource resource)
        {
            Resource = resource;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterIdentityResourceCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}