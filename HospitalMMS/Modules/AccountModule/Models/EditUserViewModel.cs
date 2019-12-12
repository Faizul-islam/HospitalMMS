using HospitalMMS.Modules.PersonModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AccountModule.Models
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime? BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }
        public String PhotoPath { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
