using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.ViewModels
{
    public class ResetPasswordViewModel : UserViewModel
    {
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Must contain at least 8 characters(at least 1 uppercase letter, 1 lowercase letter, and 1 number)")]
        public string newPassword { get; set; }


        [Required(ErrorMessage = "Confirmation Password is required.")]
        //[Compare("newPassword", ErrorMessage = "Password and Confirmation Password must match.")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        [Required]
        public string resetlink { get; set; }
    }
}
