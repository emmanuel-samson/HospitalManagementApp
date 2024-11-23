using Microsoft.EntityFrameworkCore;
using HospitalManagementApp.Models.Enitities;

namespace HospitalManagementApp.Models.Context 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}