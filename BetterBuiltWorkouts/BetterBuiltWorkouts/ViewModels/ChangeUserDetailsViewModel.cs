using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.ViewModels
{
    public class ChangeUserDetailsViewModel
    {
        [Required(ErrorMessage = "Please enter a user name.")]
        [Display(Name = "User Name")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}
