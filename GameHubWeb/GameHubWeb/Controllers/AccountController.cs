using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GameHubWeb.Models.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameHubWeb.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager,
                                 UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [Route("google-login")]
        public IActionResult GoogleLogin()
        {
            string redirectUrl = Url.Action("GoogleResponse", "Account");
            var properties = signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }


        //public async Task<IActionResult> GoogleResponse()
        //{
        //    var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        //    var claims = result.Principal.Identities.FirstOrDefault()
        //        .Claims.Select(claims => new
        //        {
        //            claims.Issuer,
        //            claims.OriginalIssuer,
        //            claims.Type,
        //            claims.Value
        //        });
        //    return Json(claims);
        //}
        //[AllowAnonymous]
        //[HttpGet("Login")]
        //public async Task<IActionResult> Login(string returnUrl)
        //{
        //    LoginViewModel model = new LoginViewModel
        //    {
        //        ReturnUrl = returnUrl,
        //        ExternalLogins =
        //        (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
        //    };

        //    return View(model);
        //}
        //[AllowAnonymous]
        //[HttpPost("ExternalLogin")]
        //public IActionResult ExternalLogin(string provider, string returnUrl)
        //{
        //    var redirectUrl = Url.Action("ExternalLoginCallback", "Account",
        //                        new { ReturnUrl = returnUrl });
        //    var properties = signInManager
        //        .ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        //    return new ChallengeResult(provider, properties);
        //}
        //[AllowAnonymous]
        //public async Task<IActionResult>
        //    ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        //{
        //    returnUrl = returnUrl ?? Url.Content("~/");

        //    LoginViewModel loginViewModel = new LoginViewModel
        //    {
        //        ReturnUrl = returnUrl,
        //        ExternalLogins =
        //                (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
        //    };

        //    if (remoteError != null)
        //    {
        //        ModelState
        //            .AddModelError(string.Empty, $"Error from external provider: {remoteError}");

        //        return View("Login", loginViewModel);
        //    }

        //    // Get the login information about the user from the external login provider
        //    var info = await signInManager.GetExternalLoginInfoAsync();
        //    if (info == null)
        //    {
        //        ModelState
        //            .AddModelError(string.Empty, "Error loading external login information.");

        //        return View("Login", loginViewModel);
        //    }

        //    // If the user already has a login (i.e if there is a record in AspNetUserLogins
        //    // table) then sign-in the user with this external login provider
        //    var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,
        //        info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

        //    if (signInResult.Succeeded)
        //    {
        //        return LocalRedirect(returnUrl);
        //    }
        //    // If there is no record in AspNetUserLogins table, the user may not have
        //    // a local account
        //    else
        //    {
        //        // Get the email claim value
        //        var email = info.Principal.FindFirstValue(ClaimTypes.Email);

        //        if (email != null)
        //        {
        //            // Create a new user without password if we do not have a user already
        //            var user = await userManager.FindByEmailAsync(email);

        //            if (user == null)
        //            {
        //                user = new ApplicationUser
        //                {
        //                    UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
        //                    Email = info.Principal.FindFirstValue(ClaimTypes.Email)
        //                };

        //                await userManager.CreateAsync(user);
        //            }

        //            // Add a login (i.e insert a row for the user in AspNetUserLogins table)
        //            await userManager.AddLoginAsync(user, info);
        //            await signInManager.SignInAsync(user, isPersistent: false);

        //            return LocalRedirect(returnUrl);
        //        }

        //        // If we cannot find the user email we cannot continue
        //        ViewBag.ErrorTitle = $"Email claim not received from: {info.LoginProvider}";
        //        ViewBag.ErrorMessage = "Please contact support on Pragim@PragimTech.com";

        //        return View("Error");
        //    }
        //}
 
        [AllowAnonymous]
        [Route("GoogleResponse")]
        public async Task<IActionResult> GoogleResponse()
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction(nameof(LoginViewModel));
 
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            string[] userInfo = { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };
            if (result.Succeeded)
                return View(userInfo);
            else
            {
                ApplicationUser user = new ApplicationUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value
                };
 
                IdentityResult identResult = await userManager.CreateAsync(user);
                if (identResult.Succeeded)
                {
                    identResult = await userManager.AddLoginAsync(user, info);
                    if (identResult.Succeeded)
                    {
                        await signInManager.SignInAsync(user, false);
                        return View(userInfo);
                    }
                }
                return AccessDenied();
            }
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
