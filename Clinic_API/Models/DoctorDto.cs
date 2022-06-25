namespace ClinicQueriesAPI.Models
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
    }
}
