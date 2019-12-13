using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class PatentTest
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int TestNameListId { get; set; }
    }
}
