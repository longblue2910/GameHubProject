using GameHub.Domain.Request.User;
using GameHub.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IUserRepository
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<ApplicationUser> Get(string id);
        Task<IEnumerable<ApplicationUser>> Gets();
        Task<bool> Update(ApplicationUser user);
    }
}
