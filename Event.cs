using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [Range(0.1, 1000)]
        public decimal Distance { get; set; }

        [Required]
        [RegularExpression("^(Run|Walk|Cycle)$")]
        public string EventType { get; set; } = "Run";

        [Required]
        public int OrganiserID { get; set; }

        public Organiser Organiser { get; set; } = null!;

        public ICollection<Category> Categories { get; set; }
            = new List<Category>();

        public ICollection<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();
    }
}
