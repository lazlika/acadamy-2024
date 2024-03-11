using System.ComponentModel.DataAnnotations;

namespace acadamy_2024.Controllers.Models
{
    public class Course
    {
        [Key]
        public int? Id { get; set; }
        [StringLength(10)]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
