
using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^(Organiser|Participant)$")]
        public string Role { get; set; } = "Participant";

        public Data.Organiser? Organiser { get; set; }

        public Participant? Participant { get; set; }
    }
}
