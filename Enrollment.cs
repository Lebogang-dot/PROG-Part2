using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [Required]
        public int ParticipantID { get; set; }

        [Required]
        public int EventID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public DateTime EnrollmentDate { get; set; }
            = DateTime.UtcNow;

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Registered";

        public Participant Participant { get; set; } = null!;

        public Event Event { get; set; } = null!;

        public Category Category { get; set; } = null!;

        public Result? Result { get; set; }
    }
}
