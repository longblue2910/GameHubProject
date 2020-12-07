using GameHub.BAL.Interface;
using GameHub.Domain.Request.Role;
using GameHub.Domain.Request.User;
using GameHub.Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(IUserService userService, UserManager<ApplicationUser> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultToken = await userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("Username or password is incorrect.");
            }
            return Ok(resultToken);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            var user = await userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return Ok("Tài khoản đã tồn tại");
            }
            if (await userManager.FindByEmailAsync(request.Email) != null)
            {
                return Ok("Emai đã tồn tại");
            }

            var result = await userService.Register(request);
            return Ok(result);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetUserPagingRequest request)
        {
            var users = await userService.GetUserPaging(request);
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var users = await userService.GetUserbyId(id);
            return Ok(users);
        }
        [HttpGet("get/{userName}")]
        public async Task<IActionResult> GetByUserName(string userName)
        {
            var user = await userService.GetUserbyUserName(userName);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Update(id, request);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}/roles")]
        public async Task<IActionResult> RoleAssign(string id, [FromBody] RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.RoleAssign(id, request);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
