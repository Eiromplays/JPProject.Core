using System;
using JPProject.Domain.Core.Commands;

namespace JPProject.Admin.Domain.Commands.Clients
{
    public abstract class ApiSecretCommand : Command
    {
        public int Id { get; protected set; }
        public string ResourceName { get; protected set; }
        public string Description { get; protected set; }

        public string Value { get; protected set; }
        public DateTime? Expiration { get; protected set; }

        public int Hash { get; protected set; } = 0;
        public string Type { get; protected set; }
    }
}