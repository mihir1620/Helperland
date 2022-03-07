using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.ViewModels
{
    public class AddressViewModel
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Mobile { get; set; }
    }
}
