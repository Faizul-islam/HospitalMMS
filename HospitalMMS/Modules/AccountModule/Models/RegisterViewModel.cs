using HospitalMMS.Modules.PersonModels;
using HospitalMMS.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AccountModule.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        //[ValidEmailDomain(allowedDomain: "gmail.com",
        //ErrorMessage = "Email domain must be pragimtech.com")]
        public string Email { get; set; }
       

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }
        public String PhotoPath { get; set; }
        public int IUser { get; set; }
        public DateTime IDate { get; set; }
        public int EUsaer { get; set; }
        public DateTime EDate { get; set; }
    }
}
