using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GameHub.Domain.Request.Role;
using GameHub.Domain.Request.User;
using GameHub.WEB.Models.Account;
using GameHub.WEB.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace GameHub.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserApiClient userApiClient;
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHost;
        private readonly IRoleApiClient roleApiClient;

        public AccountController(IUserApiClient userApiClient, IConfiguration configuration,
                                    IWebHostEnvironment webHost, IRoleApiClient roleApiClient)
        {
            this.userApiClient = userApiClient;
            this.configuration = configuration;
            this.webHost = webHost;
            this.roleApiClient = roleApiClient;
        }
        [Authorize]
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var session = HttpContext.Session.GetString("Token");
            var request = new GetUserPagingRequest()
            {
                BearerToken = session,
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await userApiClient.GetUserPadings(request);
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await userApiClient.RegisterUser(registerRequest);
            ViewBag.Message = result;
            if (result == "Register Succcess")
            {
                ViewBag.Message = result;
                //ModelState.AddModelError("", result.Message);
                return RedirectToAction("Login", "Account");
            }
            //var loginResult = await userApiClient.Authenticate(new LoginRequest()
            //{
            //    UserName = registerRequest.UserName,
            //    Password = registerRequest.Password,
            //    RememberMe = true
            //});

            //var userPrincipal = this.ValidateToken(loginResult.ResultObj);
            //var authProperties = new AuthenticationProperties
            //{
            //    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            //    IsPersistent = false
            //};
            //HttpContext.Session.SetString(SystemConstants.AppSettings.Token, loginResult.ResultObj);
            //await HttpContext.SignInAsync(
            //            CookieAuthenticationDefaults.AuthenticationScheme,
            //            userPrincipal,
            //            authProperties);

            return View(registerRequest);
        }

        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Domain.Request.User.LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);
            var token = await userApiClient.Authenticate(request);

            var userPrincipal = this.ValidateToken(token);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            HttpContext.Session.SetString("Token", token);
            var user = await userApiClient.GetByUserName(request.UserName); 
            HttpContext.Session.SetString("Id", user.Id);

            await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrincipal,
                        authProperties);

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Remove("Id");
            return RedirectToAction("Login","Account");
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var users = await userApiClient.GetById(id);
            if (users != null)
            {
                var updateRequest = new UserUpdateRequest()
                {
                    Id = id,
                    Address = users.Address,
                    Company = users.Company,
                    DoB = users.DoB,
                    Facebook = users.Facebook,
                    FullName = users.FullName,
                    Gender = users.Gender,
                    ImagePath = users.ImagePath,
                    PhoneNumber = users.PhoneNumber,
                    Roles = users.Roles
                };
                return View(updateRequest);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<OkObjectResult> Get(string id)
        {
            var users = await userApiClient.GetById(id);
            if (users != null)
            {
                var updateRequest = new UserUpdateRequest()
                {
                    Id = id,
                    Address = users.Address,
                    Company = users.Company,
                    DoB = users.DoB,
                    Facebook = users.Facebook,
                    FullName = users.FullName,
                    Gender = users.Gender,
                    ImagePath = users.ImagePath,
                    PhoneNumber = users.PhoneNumber,
                    Roles = users.Roles,
                    UserName = users.UserName
                };
                return Ok(updateRequest);
            }
            return Ok("error");
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdate request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updateRequest = new UserUpdateRequest()
            {
                Id = request.Id,
                Address = request.Address,
                Company = request.Company,
                DoB = request.DoB,
                Facebook = request.Facebook,
                FullName = request.FullName,
                Gender = request.Gender,
                PhoneNumber = request.PhoneNumber,
                Roles = request.Roles
            };
            string FileImage = null;
            if (request.ImagePath != null)
            {
                string uploadsFolder = Path.Combine(webHost.WebRootPath, "images/Avatar");
                FileImage = Guid.NewGuid().ToString() + "_" + request.ImagePath.FileName;
                string filePath = Path.Combine(uploadsFolder, FileImage);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    request.ImagePath.CopyTo(fileStream);
                }
                updateRequest.ImagePath = FileImage;
            }
                var result = await userApiClient.UpdateUser(request.Id, updateRequest);
            if (result)
            {
                return RedirectToAction("index");
            }

            return Ok("Update Fail");
        }

        [HttpGet]
        public async Task<IActionResult> RoleAssign(string id)
        {
            var roleAssignReq = await GetRoleAssignRequest(id);
            roleAssignReq.Id = id;
            return View(roleAssignReq);
        }

        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userApiClient.RoleAssign(request.Id, request);
            if (result)
            {
                return RedirectToAction("index");
            }

            ModelState.AddModelError("", "Update Role fail");
            var roleAssignReq = await GetRoleAssignRequest(request.Id);

            return View(request);
        }

        private async Task<RoleAssignRequest> GetRoleAssignRequest(string id)
        {
            var userObj = await userApiClient.GetById(id);
            var roleObj = await roleApiClient.GetAll();
            var roleAssignRequest = new RoleAssignRequest();
            foreach (var role in roleObj)
            {
                roleAssignRequest.Roles.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = true
                });
            }
            return roleAssignRequest;
        }
    }
}
