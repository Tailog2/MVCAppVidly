using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult? Details(int id)
        {

            var movie = _dbContext.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            if (movie is null)
                return NotFound();

            var viewModel = new MovieDetailsViewModel() { Movie = movie };
            return View(viewModel);

        }

        public IActionResult Index()
        {
            var movies = _dbContext.Movies.Include(m => m.Genre).ToList();

            var viewModel = new MoviesViewModel() { Movies = movies };
            return View(viewModel);
        }

        public IActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>()
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{{2}}):range(1,12)}")]
        public IActionResult ByReleasedDate(int year, byte month)
        {
            return Ok($"{year} | {month}");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            movie.DateAdded = DateTime.Today;

            if (ModelState.IsValid is false)
            {
                var genres = _dbContext.Genres.ToList();

                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = genres
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                _dbContext.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _dbContext.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public IActionResult Edit(int id)
        {
            var movie = _dbContext.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            var genres = _dbContext.Genres.ToList();

            if (movie is null)
                return NotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        public IActionResult New()
        {
            var genres = _dbContext.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }
    }
}
