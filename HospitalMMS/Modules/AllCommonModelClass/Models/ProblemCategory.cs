using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class ProblemCategory
    {
        public int Id { get; set; }
        public string ProblemCategoryName { get; set; }
        public int SpecialityId { get; set; }
    }
}
