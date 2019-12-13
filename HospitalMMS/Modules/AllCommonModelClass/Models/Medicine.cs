using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal Power { get; set; }
        public int ManufacturerId { get; set; }
    }
}
