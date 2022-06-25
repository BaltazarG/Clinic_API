using ClinicQueriesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClinicQueriesAPI.Models
{
    public class QueryUpdateDto
    {
        [Required(ErrorMessage = "Agrega un asunto")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agrega una descripcion")]
        public string Description { get; set; } = string.Empty;

        public StatusQuery? StatusQuery { get; set; }
    }
}
