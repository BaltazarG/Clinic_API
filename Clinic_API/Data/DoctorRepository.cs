using ClinicQueriesAPI.DBContexts;
using ClinicQueriesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicQueriesAPI.Data
{
    public class DoctorRepository : Repository, IDoctorRepository
    {
        public DoctorRepository(ClinicContext context) : base(context)
        {
        }

        public Doctor? GetDoctor(int doctorId)
        {
            return _context.Doctors.Include(d => d.Queries).Where(p => p.Id == doctorId).FirstOrDefault();
        }

        

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.OrderBy(c => c.Name).ToList();
        }
        public Doctor? GetDoctorByEmail(string email)
        {
            return _context.Doctors.Where(d => d.Email == email).FirstOrDefault();
        }

      
    }
}
