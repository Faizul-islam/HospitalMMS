﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PersonModels.Models
{
    public class Person
    {
        public Int64 Id { get; set; }
       
        public String PersonName { get; set; }
        public String PhoneNo { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public String PresentAddress { get; set; }
        public String PermanentAddress { get; set; }
        public String PhotoPath { get; set; }
        public int IUser { get; set; }
        public DateTime IDate { get; set; }
        public int EUsaer { get; set; }
        public DateTime EDate { get; set; }

    }
}
