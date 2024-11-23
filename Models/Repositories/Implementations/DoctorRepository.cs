using HospitalManagementApp.Models.Context;
using HospitalManagementApp.Models.Enitities;
using HospitalManagementApp.Models.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementApp.Models.Repositories.Implementation
{
    public class DoctorRepository : IDoctorRepository
    {
        protected readonly ApplicationDbContext _Context;
        public DoctorRepository(ApplicationDbContext context) 
        {
            _Context = context;
        }
        public Doctor AddDoctor(Doctor doctor)
        {
            _Context.Doctors.Add(doctor);
            _Context.SaveChanges();
            return doctor;
        }

        public void DeleteDoctor(Doctor doctor)
        {
            _Context.Doctors.Remove(doctor);
        }

       
        public List<Doctor> GetAll()
        {
            var Doctors = _Context.Doctors.ToList();
            return Doctors;
        }

        public Doctor GetDoctor(int id)
        {
            var doctors = _Context.Doctors.Find(id);
            return doctors;
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            _Context.Doctors.Update(doctor);
            _Context.SaveChanges();
            return doctor;
        }
    }
}
