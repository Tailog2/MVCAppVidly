using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie? Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; } = null!;

        public string Title
        {
            get
            {
                return Movie is null ? "New Movie" : "Edit Movie";
            }
        }

    }
}
