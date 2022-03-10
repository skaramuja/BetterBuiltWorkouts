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
            ApplicationUser user = await userManager.FindByIdAsync(id);

            await userManager.AddToRoleAsync(user, adminRole.Name);
            
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
        // If a user is suspended and were previously an Admin, the Admin role will be 
        // removed at the time of suspension. If they need to be an Admin again
        // this will have to be added back seperatly from the revocation of the suspension. 
        public async Task<IActionResult> AddToSuspended(string id)
        {
            IdentityRole suspendedRole = await roleManager.FindByNameAsync("Suspended");
            ApplicationUser user = await userManager.FindByIdAsync(id);

            user.RoleNames = await userManager.GetRolesAsync(user);
            await userManager.AddToRoleAsync(user, suspendedRole.Name);

            if (user.RoleNames != null && user.RoleNames.Contains("Admin"))
            {
                await userManager.RemoveFromRoleAsync(user, "Admin");
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromSuspended(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Suspended");
            return RedirectToAction("Index");
        }

    }
}
