using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public interface IDoctorRepository : IRepository
    {
        public Doctor? GetDoctor(int doctorId);
        public IEnumerable<Doctor> GetDoctors();
        public Doctor? GetDoctorByEmail(string email);

    }
}
