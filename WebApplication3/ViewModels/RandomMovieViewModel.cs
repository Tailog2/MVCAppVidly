using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; } = null!;
        public List<Customer> Customers { get; set; } = null!;
    }
}
