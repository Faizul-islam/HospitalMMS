using HospitalMMS.Modules.AllCommonModelClass.Models;
using HospitalMMS.Modules.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PatientModules
{
    public interface IPatientRepository
    {
        Patient GetPatient(int id);
        IEnumerable<Patient> GetAllPatient();
        Patient Add(Patient patient);
        Patient Uodate(Patient patientChanges);
        Patient Delete(int id);
    }
}
