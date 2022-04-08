using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateRented { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? DateReturned { get; set; }
}
}
