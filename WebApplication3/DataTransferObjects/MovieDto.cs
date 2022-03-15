using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DataTransferObjects
{
    public class MovieDto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int GenreId { get; set; }

        public GenreDto? Genre { get; set; }
    }
}
