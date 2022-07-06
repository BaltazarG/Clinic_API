namespace Clinic_API.Models
{
    public class DoctorWithoutQueriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Specialty { get; set; }
    }
}
