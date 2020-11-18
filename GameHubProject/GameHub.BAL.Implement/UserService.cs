using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
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

        public async Task<bool> Register(RegisterRequest request)
        {
            return await userRepository.Register(request);
        }
    }
}
