using ClinicQueriesAPI.DBContexts;

namespace ClinicQueriesAPI.Data
{
    public class Repository
    {
        internal readonly ClinicContext _context;

        public Repository(ClinicContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool IsPatient(int patientId)
        {
            return _context.Patients.Any(p => p.Id == patientId);
        }
    }
}
