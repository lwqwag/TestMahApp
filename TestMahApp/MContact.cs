﻿using System.ComponentModel.DataAnnotations;

namespace TestMahApp
{
    public class MContact: ValidatorBase
    {
        [Required(ErrorMessage = " Name is required.")]
        [StringLength(5, ErrorMessage = "No more than 5 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Name is required.")]
        [StringLength(5, ErrorMessage = "No more than 5 characters")]
        [Display(Name = "Name2")]
        public string Name2 { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50, ErrorMessage = "No more than 50 characters")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Valid email required e.g. abc@xyz.com")]
        public string Email { get; set; }


        [Display(Name = "Phone Number")]
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Entered phone format is not valid.")]
        public string Mobil { get; set; }

    }
}