namespace Clinic_API.Models
{
    public class AuthDoctorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
