using Microsoft.AspNetCore.Mvc;
using HospitalManagementApp.Models.Repositories.Interface;
using HospitalManagementApp.Models.Enitities;

namespace HospitalManagementApp.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _repository;
        public DoctorController(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var doctor = _repository.GetAll();
            return View(doctor);
        }
        public IActionResult AddDoctor() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteDoctor(int id)
        {
            var doctor = _repository.GetDoctor(id);
            if (doctor != null)
            {
                _repository.DeleteDoctor(doctor);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult UpdateDoctor(int id)
        {
            var association = _repository.GetDoctor(id);
            return View(association);
        }

        [HttpPost]
        public IActionResult UpdateDoctor(int id, string name, string speciality)
        {
            var doctor = _repository.GetDoctor(id);
            if (doctor != null)
            {
                doctor.Name = name;
                doctor.Specialty = speciality;
               _repository.UpdateDoctor(doctor);
                return RedirectToAction("Index");
            }
            return NotFound("Doctor does not exist");
        }


        [HttpPost]
        public IActionResult AddDoctor(int id, string name, string Specialty)
        {
            var doctor = new Doctor
            {
                Id = id,
                Name = name,
                Specialty = Specialty,
            };
            _repository.AddDoctor(doctor);
            return RedirectToAction("Index");
        }
    }
}
