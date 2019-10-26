using JPProject.Domain.Core.Events;

namespace Jp.Domain.Events.User
{
    public class UserClaimRemovedEvent : Event
    {
        public string Username { get; }
        public string Type { get; }

        public UserClaimRemovedEvent(string username, string type)
            : base(EventTypes.Success)
        {
            AggregateId = username;
            Username = username;
            Type = type;
        }
    }
}