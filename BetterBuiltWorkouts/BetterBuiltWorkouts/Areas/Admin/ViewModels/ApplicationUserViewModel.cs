using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.ViewModels
{
    public class ApplicationUserViewModel : ApplicationUser
    {

        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
