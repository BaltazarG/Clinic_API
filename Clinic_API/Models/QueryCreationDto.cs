using System.ComponentModel.DataAnnotations;

namespace ClinicQueriesAPI.Models
{
    public class QueryCreationDto
    {
        [Required(ErrorMessage = "Agrega un asunto")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agrega una descripcion")]
        public string Description { get; set; } = string.Empty;

        [Range(6, 13, ErrorMessage = "Debe ser un numero entre 6 y 13")]
        [Required(ErrorMessage = "Agrega un doctor")]
        public int DoctorId { get; set; }
    }
}
