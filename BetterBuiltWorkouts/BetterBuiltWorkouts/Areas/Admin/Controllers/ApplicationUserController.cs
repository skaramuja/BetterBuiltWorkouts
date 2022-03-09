using BetterBuiltWorkouts.Models;
using BetterBuiltWorkouts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ApplicationUserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public ApplicationUserController(UserManager<ApplicationUser> userManager,
                                         RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> applicationUsers = new List<ApplicationUser>();
            foreach (ApplicationUser user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                applicationUsers.Add(user);
            }
            ApplicationUserViewModel model = new ApplicationUserViewModel
            {
                ApplicationUsers = applicationUsers,
                Roles = roleManager.Roles
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete (string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            if  (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    string errorMessage = "";

                        foreach(IdentityError error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }

                    TempData["message"] = errorMessage;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            IdentityRole adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null) {
                TempData["message"] = "Admin role does not exist. Click 'Create Admin Role' button to create it.";
            }
            else 
            {
                ApplicationUser user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, adminRole.Name);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public  async Task<IActionResult> RemoveFromAdmin(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Admin");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            await roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole(string id)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
            return RedirectToAction("Index");
        }

    }
}
