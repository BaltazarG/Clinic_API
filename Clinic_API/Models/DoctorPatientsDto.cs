using ClinicQueriesAPI.Models;

namespace Clinic_API.Models
{
    public class DoctorPatientsDto
    {
        public ICollection<PatientDto> Patients { get; set; } = new List<PatientDto>();
    }
}
