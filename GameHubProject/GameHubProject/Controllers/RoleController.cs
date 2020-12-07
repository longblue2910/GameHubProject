using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        [HttpGet("gets")]
        public async Task<IActionResult> GetAll()
        {
            var roles = await roleService.GetAll();
            return Ok(roles);
        }
    }
}
