using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public int? ProblemCategoryId { get; set; }
        public string ProblemDescription { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public string PhotoPath { get; set; }

        public int? IUser { get; set; }
        public DateTime? IDate { get; set; }
        public int? EUser { get; set; }
        public DateTime? EDate { get; set; }

    }
}
