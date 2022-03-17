using System.ComponentModel.DataAnnotations;

namespace Vidly.DataTransferObjects
{
    public class GenreDto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; } = null!;
    }
}
