using HelperLand.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelperLand.ViewModels
{
    public class UserViewModel 
    {

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Must contain at least 8 characters(at least 1 uppercase letter, 1 lowercase letter, and 1 number)")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public bool Emailsent { get; set; }

        public string ReserPasswordLink { get; set; }
        [Required]
        public string Mobile { get; set; }
        public int? UserTypeId { get; set; }
        //public int? Gender { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public string? UserProfilePicture { get; set; }
        public bool? IsRegisteredUser { get; set; }
        //public string? PaymentGatewayUserRef { get; set; }
        //public string? ZipCode { get; set; }
        public bool? WorksWithPets { get; set; }
        public int? LanguageId { get; set; }
        public int? NationalityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        //public int? Status { get; set; }
        //public string? BankTokenId { get; set; }
        //public string? TaxNo { get; set; }

        [Required]
        public bool isChecked { get; set; }

      
    }
}
