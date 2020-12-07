using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Common1;
using GameHub.Domain.Request.Role;
using GameHub.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<string> Authencate(LoginRequest request)
        {
            return await userRepository.Authencate(request);
        }

        public async Task<UserViewModel> GetUserbyId(string id)
        {
            return await userRepository.GetUserbyId(id);
        }

        public async Task<UserViewModel> GetUserbyUserName(string UserName)
        {
            return await userRepository.GetUserbyUserName(UserName);
        }

        public async Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request)
        {
            return await userRepository.GetUserPaging(request);
        }

        public async Task<string> Register(RegisterRequest request)
        {
            return await userRepository.Register(request);
        }

        public async Task<bool> RoleAssign(string id, RoleAssignRequest request)
        {
            return await userRepository.RoleAssign(id, request);
        }

        public async Task<bool> Update(string id, UserUpdateRequest request)
        {
            return await userRepository.Update(id, request);
        }
    }
}
