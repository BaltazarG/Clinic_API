using System.ComponentModel.DataAnnotations;

namespace ClinicQueriesAPI.Models
{
    public class PatientCreationDto
    {
        [Required(ErrorMessage = "Ingrese un nombre")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese un apellido")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingresa un email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingresa una contraseña")]
        public string Password { get; set; } = string.Empty;


        public string UserType { get; } = "patient";

    }
}
