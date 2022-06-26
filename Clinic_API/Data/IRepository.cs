namespace ClinicQueriesAPI.Data
{
    public interface IRepository
    {
        bool SaveChanges();
        public bool IsPatient(int patientId);
        public bool IsDoctor(int doctorId);

    }
}
