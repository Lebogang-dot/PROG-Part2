using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public int EventID { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        [StringLength(20)]
        public string CategoryType { get; set; } = "Age";

        public int? MinimumAge { get; set; }

        public int? MaximumAge { get; set; }

        public decimal? MinimumDistance { get; set; }

        public decimal? MaximumDistance { get; set; }

        public Event Event { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();
    }
}
