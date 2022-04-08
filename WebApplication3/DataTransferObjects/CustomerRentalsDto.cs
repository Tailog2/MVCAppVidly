using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Models;

namespace WebApplication3.DataTransferObjects
{
    public class CustomerRentalsDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public List<int> MovieIds { get; set; } = null!;

        public List<MovieDto>? MoviesDto { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Rent Date")]
        public DateTime DateRented { get; set; }

        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Return Date")]
        public DateTime? DateReturned { get; set; }
    }
}
