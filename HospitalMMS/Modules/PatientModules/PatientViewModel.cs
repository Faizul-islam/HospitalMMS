using HospitalMMS.Modules.AllCommonModelClass.Models;
using HospitalMMS.Modules.PersonModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PatientModules
{
    public class PatientViewModel
    {

        #region Patient
        public string Id { get; set; }
        public int? ProblemCategoryId { get; set; }
        public string ProblemDescription { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public string PhotoPath { get; set; }

        public int? IUser { get; set; }
        public DateTime? IDate { get; set; }
        public int? EUser { get; set; }
        public DateTime? EDate { get; set; }
        #endregion

        #region Person/User (Asp .Net User)
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
       // public string PersonId { get; set; }
        public DateTime? BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }
        #endregion

        #region Problem Category
        public string ProblemCategoryName { get; set; }
        public int? SpecialityId { get; set; }
        #endregion

        #region Employee
        public string PersonId { get; set; }
        public int? SpecialtyId { get; set; }
        public int? PositionId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal Salary { get; set; }
        // public string PhotoPath { get; set; }
        #endregion

        #region Other

        public int Ids { get; set; }
        public string TempPersonId { get; set; }
        public IFormFile Photo { get; set; }
        public string ExistingPhotoPath { get; set; }
        public Patient Patient { get; internal set; }
        public string PageTitle { get; set; }
        #endregion

    }
}
