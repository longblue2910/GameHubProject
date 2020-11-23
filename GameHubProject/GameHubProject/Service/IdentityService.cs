using GameHub.API.DbContext;
using GameHub.DAL.Interface;
using GameHub.Domain.User;
using Jose;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.API.Service
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration config;
        private readonly ISocialRepository socialRepository;

        public IdentityService(UserManager<ApplicationUser> userManager, AppDbContext context, 
                                RoleManager<IdentityRole> roleManager, IConfiguration config,
                                                   ISocialRepository socialRepository)
        {
            this.userManager = userManager;
            _context = context;
            this.roleManager = roleManager;
            this.config = config;
            this.socialRepository = socialRepository;
        }
        public async Task<AuthenticationResult> LoginWithFacebookAsync(string accessToken)
        {
            var ValidatedTokenResult = await socialRepository.ValidateAccessTokenAsync(accessToken);
            if (!ValidatedTokenResult.Data.IsValid)
            {
                return new AuthenticationResult()
                {
                    Error = "Invalid Facebook token"
                };
            }
            var userInfo = await socialRepository.GetUserInfoAsync(accessToken);

            var user = await userManager.FindByEmailAsync(userInfo.Email);
            if (user == null)
            {
                var applicationUser = new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = userInfo.Email,
                    UserName = userInfo.Email
                };
                var createResult = await userManager.CreateAsync(applicationUser);
                if (!createResult.Succeeded)
                {
                    return new AuthenticationResult
                    {
                        Error = "Something went wrong"
                    };
                }
                return await GenerateAuthenticationResultForUserAsync(applicationUser);
            }
            return await GenerateAuthenticationResultForUserAsync(user);
        }
        public async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(ApplicationUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaa");

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("id", user.Id)
            };

            var userClaims = await userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);

            var userRoles = await userManager.GetRolesAsync(user);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
                var role = await roleManager.FindByNameAsync(userRole);
                if (role == null) continue;
                var roleClaims = await roleManager.GetClaimsAsync(role);

                foreach (var roleClaim in roleClaims)
                {
                    if (claims.Contains(roleClaim))
                        continue;

                    claims.Add(roleClaim);
                }
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var refreshToken = new RefreshToken
            {
                JwtId = token.Id,
                UserId = user.Id,
                CreationDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddMonths(6)
            };

            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return new AuthenticationResult
            {
                Success = true,
                Token = tokenHandler.WriteToken(token),
                RefreshToken = refreshToken.Token
            };
        }
    }
}
