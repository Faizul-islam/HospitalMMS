using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class DoctorBillPayment
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal PaidBillAmount { get; set; }
        public int PatientId { get; set; }
    }
}
