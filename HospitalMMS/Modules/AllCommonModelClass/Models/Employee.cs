using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string PersonId { get; set; }
        public int SpecialtyId { get; set; }
        public int PositionId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal Salary { get; set; }
        public string PhotoPath { get; set; }

        public int IUser { get; set; }
        public DateTime IDate { get; set; }
        public int EUsaer { get; set; }
        public DateTime EDate { get; set; }

    }
}
