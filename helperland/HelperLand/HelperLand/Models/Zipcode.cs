using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HelperLand.Models
{
    public partial class Zipcode
    {
        public int Id { get; set; }

        [Required]
        public string ZipcodeValue { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}
