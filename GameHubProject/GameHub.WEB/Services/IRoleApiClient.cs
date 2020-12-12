using GameHub.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Services
{
    public interface IRoleApiClient
    {
        Task<List<RoleView>> GetAll();
    }
}
