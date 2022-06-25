namespace ClinicQueriesAPI.Models
{
    public class PatientWithoutQueriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
    }
}
