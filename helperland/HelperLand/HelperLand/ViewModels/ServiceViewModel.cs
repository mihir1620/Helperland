using HelperLand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        [Required]
        public string ZipcodeValue { get; set; }
        public int CityId { get; set; }
        public string s_checkbox { get; set; }
        [Required]
        public string City { get; set; }
        public ServiceRequest service { get; set; }
        public int ServiceRequestId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ServiceStartDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime ServiceTime { get; set; }
        public string ZipCode { get; set; }
        public decimal? ServiceHourlyRate { get; set; }
        public double ServiceHours { get; set; }
        public double? ExtraHours { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? Discount { get; set; }

        [TempData]
        public decimal TotalCost { get; set; }
        public string Comments { get; set; }
        public string PaymentTransactionRefNo { get; set; }
        public bool PaymentDue { get; set; }
        public int? ServiceProviderId { get; set; }
        public DateTime? SpacceptedDate { get; set; }
        public bool HasPets { get; set; }
        public int? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public decimal? RefundedAmount { get; set; }
        public decimal Distance { get; set; }
        public bool? HasIssue { get; set; }
        public bool? PaymentDone { get; set; }
        public Guid? RecordVersion { get; set; }
        public int AddressId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        [Required]
        public string AddressLine2 { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Mobile { get; set; }

        public int ServiceExtraId { get; set; }
    }
}
