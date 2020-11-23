using GameHub.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.API.Service
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> LoginWithFacebookAsync(string accessToken);
    }
}
