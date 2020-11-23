using GameHub.DAL.Interface;
using GameHub.Domain.Request.User;
using GameHub.Domain.User;
using Jose;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _config;
        private readonly ISocialRepository socialRepository;

        public UserRepository(UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager,
                               RoleManager<IdentityRole> roleManager, IConfiguration config
                               )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _config = config;
            this.socialRepository = socialRepository;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            var user = await userManager.FindByNameAsync(request.UserName);
            if (user == null) return null;
            var result = await signInManager.PasswordSignInAsync(user, request.PassWord, request.RememberMe, true);
            if(!result.Succeeded)
            {
                return null;
            }

            var roles = userManager.GetRolesAsync(user);
            var Claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FullName),
                new Claim(ClaimTypes.Role, string.Join(";", roles))
            };
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //var token = new JwtSecurityToken(_config["Tokens:Issuer"],
            //    _config["Tokens:Issuer"],
            //    Claims,
            //    expires: DateTime.Now.AddHours(3),
            //    signingCredentials: creds);
            //return new JwtSecurityTokenHandler().WriteToken(token);
            return $"Login success";
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new ApplicationUser()
            {
                UserName = request.UserName,
                DoB = request.DoB.ToString("dd/MM/yyyy"),
                Address = request.Address,
                Email = request.Email,
                Company = request.Company,
                Facebook = request.Facebook,
                FullName = request.FullName,
                Gender = request.Gender,
                ImagePath = request.ImagePath,
                IsDelete = false
            };
            var result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
        public async Task<string> Logout()
        {
            await signInManager.SignOutAsync();
            return "Logout Success";
        }

        public async Task<ApplicationUser> Get(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = new ApplicationUser()
                {
                    Address = user.Address,
                    Email = user.Email,
                    FullName = user.FullName,
                    Id = user.Id,
                    PhoneNumber = user.PhoneNumber,
                    UserName = user.UserName,
                    ImagePath = user.ImagePath,
                    DoB = user.DoB,
                    Company = user.Company,
                    Facebook = user.Facebook,
                    Gender = user.Gender
                };
                //var roleName = await userManager.GetRolesAsync(user);
                //if (roleName != null && roleName.Any())
                //{
                //    var role = await roleManager.FindByNameAsync(roleName.FirstOrDefault());
                //    result.RoleId = role.Id;
                //}
                return result;
            }
            return new ApplicationUser();
        }

        public async Task<IEnumerable<ApplicationUser>> Gets()
        {
            var users = userManager.Users;
            //if (user != null && user.Any())
            //{
            //    var model = new List<User>();
            //    model = user.Select(u => new User()
            //    {
            //        Address = u.Address,
            //        Email = u.Email,
            //        Id = u.Id,
            //        UserName = u.UserName,
            //    }).ToList();
            //    foreach (var user1 in model)
            //    {
            //        user1.RoleName = GetRolesName(user1.Id);
            //    }
            //    return View(model);
            //}
            return users;
        }

        public async Task<bool> Update(ApplicationUser model)
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if (user != null)
            {
                user.Address = model.Address;
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.Id = model.Id;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.UserName;
                user.ImagePath = model.ImagePath;
                user.DoB = model.DoB;
                user.Company = model.Company;
                user.Facebook = model.Facebook;
                user.Gender = model.Gender;
                user.IsDelete = model.IsDelete;

                var result = await userManager.UpdateAsync(user);
                //if (result.Succeeded)
                //{
                //    var rolesName = await userManager.GetRolesAsync(user);
                //    if (!string.IsNullOrEmpty(model.RoleId))
                //    {
                //        var role = await roleManager.FindByIdAsync(model.RoleId);
                //        var add = await userManager.AddToRoleAsync(user, role.Name);
                //        if (add.Succeeded)
                //        {
                //            return RedirectToAction("List", "Account");
                //        }
                //        foreach (var error in add.Errors)
                //        {
                //            ModelState.AddModelError("", error.Description);
                //        }
                //    }

                //}
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError("", error.Description);
                //}
                return true;
            }
            return false;
        }

        //public async Task<AuthenticationResult> LoginWithFacebookAsync(string accessToken)
        //{
        //    var ValidatedTokenResult = await socialRepository.ValidateAccessTokenAsync(accessToken);
        //    if (!ValidatedTokenResult.Data.IsValid)
        //    {
        //        return new AuthenticationResult()
        //        {
        //            Error = "Invalid Facebook token"
        //        };
        //    }
        //    var userInfo = await socialRepository.GetUserInfoAsync(accessToken);

        //    var user = await userManager.FindByEmailAsync(userInfo.Email);
        //    if(user == null)
        //    {

        //    }
        //    return await GenerateAuthenticationResultForUserAsync(user);
        //}
        //public async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(ApplicationUser user)
        //{
        //    return null;
        //}
    }
}
