using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.User;
using GameHub.Domain.User;
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

        public async Task<ApplicationUser> Get(string id)
        {
            return await userRepository.Get(id);
        }

        public async Task<IEnumerable<ApplicationUser>> Gets()
        {
            return await userRepository.Gets();
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            return await userRepository.Register(request);
        }

        public async Task<bool> Update(ApplicationUser user)
        {
            return await userRepository.Update(user);
        }
    }
}
