using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string Password{ get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword{ get; set; }


    }
}
