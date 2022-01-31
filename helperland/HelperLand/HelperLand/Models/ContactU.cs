using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HelperLand.Models
{
    public partial class ContactU 
    {
        public int ContactUsId { get; set; }

        [Required]
        public string Name { get; set; }

        //[Required]
        //public string LastName { get; set; }

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
        public string FileName { get; set; }
    }
}
