using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalMMS.Data;
using HospitalMMS.Modules.AllCommonModelClass.Models;

namespace HospitalMMS.Modules.PatientModules
{
    public class SQLPatientRepository : IPatientRepository
    {
        private readonly AppDbContext context;

        public SQLPatientRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Patient Add(Patient patient)
        {
            context.Patient.Add(patient);
            context.SaveChanges();
            return patient;
        }

        public Patient Delete(int id)
        {
            Patient patient = context.Patient.Find(id);
            if (patient != null)
            {
                context.Patient.Remove(patient);
                context.SaveChanges();
            }
            return patient;
        }

        public IEnumerable<Patient> GetAllPatient()
        {
            return context.Patient;
        }

        public Patient GetPatient(int id)
        {
            return context.Patient.Find(id);
        }

        public Patient Uodate(Patient patientChanges)
        {
            var patient = context.Patient.Attach(patientChanges);
            patient.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return patientChanges;
        }
    }
}
