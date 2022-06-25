namespace ClinicQueriesAPI.Models
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public ICollection<QueryDto> Queries { get; set; } = new List<QueryDto>();
    }
}
