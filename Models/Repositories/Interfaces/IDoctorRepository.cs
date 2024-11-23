using HospitalManagementApp.Models.Enitities;

namespace HospitalManagementApp.Models.Repositories.Interface
{
    public interface IDoctorRepository
    {
        Doctor GetDoctor(int id);
        List<Doctor> GetAll();
        Doctor AddDoctor(Doctor doctor);
        Doctor UpdateDoctor(Doctor doctor);
        void DeleteDoctor(Doctor doctor);
    }
}
