﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.AllCommonModelClass.Models
{
    public class MaxPatientCountForAppointment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int AppointmentCount { get; set; }
    }
}