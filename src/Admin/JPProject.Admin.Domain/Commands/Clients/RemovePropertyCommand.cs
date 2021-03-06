using JPProject.Admin.Domain.Validations.Client;

namespace JPProject.Admin.Domain.Commands.Clients
{
    public class RemovePropertyCommand : ClientPropertyCommand
    {

        public RemovePropertyCommand(string key, string value, string clientId)
        {
            Value = value;
            Key = key;
            ClientId = clientId;
        }


        public override bool IsValid()
        {
            ValidationResult = new RemovePropertyCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}