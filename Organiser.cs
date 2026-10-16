
using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models
{
    public class Organiser
    {
        [Key]
        public int OrganiserID { get; set; }

        [Required]
        public int UserID { get; set; }

        [StringLength(150)]
        public string? OrganisationName { get; set; }

        public User User { get; set; } = null!;

        public ICollection<Event> Events { get; set; }
            = new List<Event>();
    }
}
