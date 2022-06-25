using System.ComponentModel.DataAnnotations;

namespace ClinicQueriesAPI.Models
{
    public class QueryCreationDto
    {
        [Required(ErrorMessage = "Agrega un asunto")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agrega una descripcion")]
        public string Description { get; set; } = string.Empty;
        public int DoctorId { get; set; }
    }
}
