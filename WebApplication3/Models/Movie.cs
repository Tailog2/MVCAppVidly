using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please enter movie's release date")]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter movie's date of adding")]
        [Display(Name = "Date of Adding")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        [Required(ErrorMessage = "Please enter movie's number in stock")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

        
        [Required(ErrorMessage = "Please select movie's genre")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}
