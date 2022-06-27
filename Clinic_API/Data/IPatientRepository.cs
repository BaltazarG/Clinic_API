using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public interface IPatientRepository : IRepository
    {
        public Patient? GetPatient(int patientId);
        public IEnumerable<Patient> GetPatients();
        public void AddPatient(Patient newPatient);
        public Patient? GetPatientByEmail(string email);

    }
}
