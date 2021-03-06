using JPProject.Admin.Domain.Validations.Client;

namespace JPProject.Admin.Domain.Commands.Clients
{
    public class RemoveClientClaimCommand : ClientClaimCommand
    {
        public RemoveClientClaimCommand(string type, string value, string clientId)
        {
            Type = type;
            Value = value;
            ClientId = clientId;
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveClientClaimCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public bool ByType()
        {
            return string.IsNullOrEmpty(Value);
        }
    }
}