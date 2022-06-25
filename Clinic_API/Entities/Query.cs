
using ClinicQueriesAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicQueriesAPI.Entities
{
    public class Query
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
        public int PatientId { get; set; }

        public StatusQuery StatusQuery { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ResolvedAt { get; set; }


        public int DoctorId { get; set; }

        public Query(string title, string description)
        {
            Description = description;
            Title = title;
        }

    }
}
