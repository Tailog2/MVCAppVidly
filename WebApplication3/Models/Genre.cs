using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
    }
}
