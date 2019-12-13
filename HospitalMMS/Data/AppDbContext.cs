using HospitalMMS.Modules.AccountModule.Models;
using HospitalMMS.Modules.AllCommonModelClass.Models;
using HospitalMMS.Modules.PersonModels.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Person> Person { get; set; }
        public DbSet<Consultation> Consultation { get; set; }
        public DbSet<DoctorBillPayment> DoctorBillPayment { get; set; }
        public DbSet<DoctorsSchedule> DoctorsSchedule { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendance { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<MaxPatientCountForAppointment> MaxPatientCountForAppointment { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<PatentTest> PatentTest { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<ProblemCategory> ProblemCategory { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<TestBillPayment> TestBillPayment { get; set; }
        public DbSet<TestNameList> TestNameList { get; set; }
    }
}
