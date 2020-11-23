using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GameHub.API.Service;
using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.User;
using GameHub.Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IIdentityService identityService;

        public UserController(IUserService userService, SignInManager<ApplicationUser> signInManager,
                                IIdentityService identityService)
        {
            this.userService = userService;
            this.signInManager = signInManager;
            this.identityService = identityService;
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
            return Ok("Login Success");
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Register(request);
            if (!result )
            {
                return BadRequest("Register is unsuccessful!");
            }
            return Ok("Register is successful!");
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Ok("Successful");
        }
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Get(id);
            
            return Ok(result);
        }
        [HttpGet("Gets")]
        public async Task<IActionResult> Gets()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Gets();

            return Ok(result);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] ApplicationUser model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Update(model);
            if (!result)
            {
                return BadRequest("Update is unsuccessful!");
            }
            return Ok("Update is successful!");
        }
        [HttpPost("Loginfb")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserFacebookAuthRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var authResponse = await identityService.LoginWithFacebookAsync(request.AccessToken);

            if (!authResponse.Success)
            {
                return BadRequest(authResponse.Error);
            }

            return Ok(new AuthenticationResult{
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });

        }
       
    }
}
