using GameHub.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface IRoleService
    {
        Task<List<RoleView>> GetAll();
    }
}
