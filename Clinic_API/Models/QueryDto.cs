using ClinicQueriesAPI.Enums;
using System.Text.Json.Serialization;

namespace ClinicQueriesAPI.Models
{
    public class QueryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusQuery StatusQuery { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ResolvedAt { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string? Diagnostic { get; set; }
    }
}

