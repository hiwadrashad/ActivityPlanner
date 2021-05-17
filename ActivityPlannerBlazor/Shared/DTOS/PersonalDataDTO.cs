using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class PersonalDataDTO
    {
        [Required]
        public string Name { get; set; }
        [Display(Name = "Telephone number")]
        [Required]
        public string TelephoneNumber { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
        [Display(Name = "Street name")]
        public string StreetName { get; set; }
        [Display(Name = "Streer Number")]
        public string StreetNumber { get; set; }

    }
}
