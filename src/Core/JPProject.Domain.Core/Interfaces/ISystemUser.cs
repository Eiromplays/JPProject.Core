using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace JPProject.Domain.Core.Interfaces
{
    public interface ISystemUser
    {
        string Username { get; }
        bool IsAuthenticated();
        Guid UserId { get; }
        IEnumerable<Claim> GetClaimsIdentity();
        string GetRemoteIpAddress();
        string GetLocalIpAddress();
    }
}
