using GameHub.DAL.Interface;
using GameHub.Domain.Roles;
using GameHub.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleRepository(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task<List<RoleView>> GetAll()
        {
            var roles = await roleManager.Roles.Select(x => new RoleView()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

            return roles;
        }
    }
}
