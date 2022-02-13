using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BetterBuiltWorkouts.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
    }
}
