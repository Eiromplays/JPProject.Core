using JPProject.Admin.Domain.Commands.Clients;

namespace JPProject.Admin.Domain.Validations.Client
{
    public class RemoveClientCommandValidation : ClientValidation<RemoveClientCommand>
    {
        public RemoveClientCommandValidation()
        {
            ValidateClientId();
        }
    }
}