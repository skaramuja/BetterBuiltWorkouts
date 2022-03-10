using BetterBuiltWorkouts.Models;
using BetterBuiltWorkouts.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("~/Home/Index");
        }


        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                        Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }


        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser user = await userManager.FindByNameAsync(model.Username);
                var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    TempData["message"] = "Password updated successfully!";
                    TempData["style"] = "success";

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> ChangeUserDetails()
        {
            ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
            ChangeUserDetailsViewModel model = new ChangeUserDetailsViewModel();

            model.Username = user.UserName;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUserDetails(ChangeUserDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);

                user.UserName = model.Username;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;

                IdentityResult result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
