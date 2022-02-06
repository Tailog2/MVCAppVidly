using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date of Adding")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
    }
}
