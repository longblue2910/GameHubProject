using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public async Task<List<RoleView>> GetAll()
        {
            return await roleRepository.GetAll();
        }
    }
}
