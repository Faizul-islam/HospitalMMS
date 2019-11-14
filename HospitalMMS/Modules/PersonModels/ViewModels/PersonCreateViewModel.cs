using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PersonModels.ViewModels
{
    public class PersonCreateViewModel
    {
        public Int32 RoleId { get; set; }
        public String PersonName { get; set; }
        public String PhoneNo { get; set; }
        public String Email { get; set; }
        public Int32 Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }
        public IFormFile PhotoPath { get; set; }

    }
}
