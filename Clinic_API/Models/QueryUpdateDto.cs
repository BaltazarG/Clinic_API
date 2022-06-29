using ClinicQueriesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClinicQueriesAPI.Models
{
    public class QueryUpdateDto
    {
        [Required(ErrorMessage = "Agrega un estado")]
        public StatusQuery? StatusQuery { get; set; }
        [Required(ErrorMessage = "Agrega un diagnostico")]
        public string Diagnostic { get; set; }
    }
}
