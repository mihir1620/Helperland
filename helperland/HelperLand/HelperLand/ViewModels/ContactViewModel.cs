using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.ViewModels
{
    public class ContactViewModel 
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string Subject { get; set; }

        [Required, MinLength(10, ErrorMessage = "Phone Number should be 10 characters"), MaxLength(10, ErrorMessage = "Phone Number cannot exceed 10 characters")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Message { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public IFormFile File { get; set; }
    }
}
