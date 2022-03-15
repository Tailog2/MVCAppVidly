using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class MovieFormViewModel
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter movie's release date")]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Required(ErrorMessage = "Please enter movie's number in stock")]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }


        [Required(ErrorMessage = "Please select movie's genre")]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; } = null!;

        public string Title
        {
            get
            {
                return Id == 0 ? "New Movie" : "Edit Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
        }
    }
}
