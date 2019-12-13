using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class TestBillPayment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal PaidBillAmount { get; set; }
    }
}
