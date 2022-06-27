using ClinicQueriesAPI.DBContexts;
using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public class PatientRepository : Repository, IPatientRepository
    {
        public PatientRepository(ClinicContext context) : base(context)
        {
        }

        public Patient? GetPatient(int patientId)
        {
            return _context.Patients.Where(p => p.Id == patientId).FirstOrDefault();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.OrderBy(c => c.Name).ToList();
        }

        public void AddPatient(Patient newPatient)
        {
            
            if (newPatient != null)
                _context.Patients.Add(newPatient);
        }

        public Patient? GetPatientByEmail(string email)
        {
            return _context.Patients.Where(p => p.Email == email).FirstOrDefault();
        }
    }
}
