using GameHub.DAL.Interface;
using GameHub.Domain;
using GameHub.Domain.Common1;
using GameHub.Domain.Request.Role;
using GameHub.Domain.Request.User;
using GameHub.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _config;

        public UserRepository(UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager,
                               RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _config = config;
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
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                Claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
            //return $"Login success";
        }

        public async Task<string> Register(RegisterRequest request)
        {
            var user = new ApplicationUser()
            {
                UserName = request.UserName,
                DoB = request.DoB.ToString("dd/MM/yyyy"),
                //Address = request.Address,
                Email = request.Email,
                
                //Company = request.Company,
                //Facebook = request.Facebook,
                //FullName = request.FullName,
                //Gender = request.Gender,
                //ImagePath = request.ImagePath,
                IsDelete = false
            };
            var createuser = await userManager.FindByNameAsync(request.UserName);
            if(createuser != null)
            {
                return "UserName is Exist!";
            }
            if (await userManager.FindByEmailAsync(request.Email) != null)
            {
                return "Email is Exist!";
            }
            var result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return "Register Succcess";
            }
            return "Register Unsucccessly";
        }
        public async Task<string> Logout()
        {
            await signInManager.SignOutAsync();
            return "Logout Success";
        }

        public async Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request)
        {
            var query = userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword) ||
                x.PhoneNumber.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(x => new UserViewModel()
                {
                    Id = x.Id,
                    Address = x.Address,
                    Company= x.Company,
                    DoB = x.DoB,
                    Facebook = x.Facebook,
                    FullName = x.FullName,
                    Gender = x.Gender,
                    ImagePath = x.ImagePath,
                    IsDelete = x.IsDelete
                }).ToListAsync();

            var PagedResult = new PagedResult<UserViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return PagedResult;
        }
        public async Task<bool> Update(string id, UserUpdateRequest request)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            user.DoB = request.DoB;
            user.FullName = request.FullName;
            user.Facebook = request.Facebook;
            user.PhoneNumber = request.PhoneNumber;
            user.Gender = request.Gender;
            user.ImagePath = request.ImagePath;

            var result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<UserViewModel> GetUserbyId(string id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return null;
            }
            var roles = await userManager.GetRolesAsync(user);
            var userVm = new UserViewModel()
            {
                PhoneNumber = user.PhoneNumber,
                FullName = user.FullName,
                DoB = user.DoB,
                Id = user.Id,
                Gender = user.Gender,
                Facebook = user.Facebook,
                ImagePath = user.ImagePath,
                Address = user.Address,
                Company = user.Company
                //Roles = roles
            };
            return userVm;
        }

        public async Task<UserViewModel> GetUserbyUserName(string UserName)
        {
            var user = await userManager.FindByNameAsync(UserName.ToString());
            if (user == null)
            {
                return null;
            }
            var roles = await userManager.GetRolesAsync(user);
            var userVm = new UserViewModel()
            {
                PhoneNumber = user.PhoneNumber,
                FullName = user.FullName,
                DoB = user.DoB,
                Id = user.Id,
                Gender = user.Gender,
                Facebook = user.Facebook,
                ImagePath = user.ImagePath,
                Address = user.Address,
                Company = user.Company
                //Roles = roles
            };
            return userVm;
        }

        public async Task<bool> RoleAssign(string id, RoleAssignRequest request)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return false;
            }
            var removedRoles = request.Roles.Where(x => x.Selected == false).Select(x => x.Name).ToList();
            foreach (var roleName in removedRoles)
            {
                if (await userManager.IsInRoleAsync(user, roleName) == true)
                {
                    await userManager.RemoveFromRoleAsync(user, roleName);
                }
            }
            await userManager.RemoveFromRolesAsync(user, removedRoles);

            var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
            foreach (var roleName in addedRoles)
            {
                if (await userManager.IsInRoleAsync(user, roleName) == false)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }

            return true;
        }
    }
}
