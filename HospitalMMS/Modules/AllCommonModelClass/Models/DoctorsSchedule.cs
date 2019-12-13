using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class DoctorsSchedule
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime? Day { get; set; }
        public DateTime? Time { get; set; }

        public int IUser { get; set; }
        public DateTime IDate { get; set; }
        public int EUsaer { get; set; }
        public DateTime EDate { get; set; }
    }
}
