﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class TestNameList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal Price { get; set; }
    }
}