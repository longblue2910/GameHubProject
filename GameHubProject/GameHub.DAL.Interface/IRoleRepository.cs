using GameHub.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IRoleRepository
    {
        Task<List<RoleView>> GetAll();
    }
}
