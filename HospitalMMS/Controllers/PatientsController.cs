using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HospitalMMS.Modules.AllCommonModelClass.Models;
using HospitalMMS.Modules.EmployeeModule;
using HospitalMMS.Modules.PatientModules;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HospitalMMS.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public PatientsController(IPatientRepository patientRepository, IHostingEnvironment hostingEnvironment)
        {
            _patientRepository = patientRepository;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _patientRepository.GetAllPatient();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            PatientViewModel patientViewModel = new PatientViewModel()
            {
                Patient = _patientRepository.GetPatient(id),
                PageTitle = "Patient Details"
            };

            return View(patientViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PatientViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Patient newPatient = new Patient
                {
                    PersonId = model.PersonId,
                    ProblemCategoryId = model.ProblemCategoryId,
                    ProblemDescription = model.ProblemDescription,
                    EmployeeId = model.EmployeeId,
                    Date = model.Date,
                    IUser = 1,
                    IDate = DateTime.Now,
                    EUser = 0,
                    EDate = null,

                    PhotoPath = uniqueFileName
                };

                _patientRepository.Add(newPatient);
                return RedirectToAction("details", new { id = newPatient.Id });
            }

            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            
            Patient patient = _patientRepository.GetPatient(id);
            PatientViewModel patientViewModel = new PatientViewModel
            {
                Ids = patient.Id,
                PersonId = patient.PersonId,
                ProblemCategoryId = patient.ProblemCategoryId,
                ProblemDescription = patient.ProblemDescription,
                EmployeeId = patient.EmployeeId,
                Date = patient.Date,

                ExistingPhotoPath = patient.PhotoPath
            };
            return View(patientViewModel);
        }

    }
}
