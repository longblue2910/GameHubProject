using GameHub.Domain.Common1;
using GameHub.Domain.Request.Role;
using GameHub.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<PagedResult<UserViewModel>> GetUserPadings(GetUserPagingRequest request);
        Task<string> RegisterUser(RegisterRequest registerRequest);
        Task<bool> UpdateUser(string id, UserUpdateRequest registerRequest);
        Task<bool> RoleAssign(string id, RoleAssignRequest registerRequest);
        Task<UserViewModel> GetById(string id);
        Task<UserViewModel> GetByUserName(string UserName);
    }
}
