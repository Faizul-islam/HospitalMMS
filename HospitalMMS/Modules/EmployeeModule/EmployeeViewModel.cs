using HospitalMMS.Modules.PersonModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.EmployeeModule
{
    public class EmployeeViewModel
    {
        #region Employee
        public int Id { get; set; }

        public string PersonId { get; set; }
        public int SpecialtyId { get; set; }
        public int PositionId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal Salary { get; set; }
        public IFormFile PhotoPath { get; set; }

        #endregion

        #region Common Fild
        public int IUser { get; set; }
        public DateTime IDate { get; set; }
        public int EUsaer { get; set; }
        public DateTime EDate { get; set; }
        #endregion

        #region Person/User
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public DateTime? BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }

        #endregion


        #region Other
        public string TempPersonId { get; set; }
        #endregion
    }
}
