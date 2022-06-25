using ClinicQueriesAPI.DBContexts;
using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public class DoctorRepository : Repository, IDoctorRepository
    {
        public DoctorRepository(ClinicContext context) : base(context)
        {
        }

        public Doctor? GetDoctor(int doctorId)
        {
            return _context.Doctors.Where(p => p.Id == doctorId).FirstOrDefault();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.OrderBy(c => c.Name).ToList();
        }
    }
}
