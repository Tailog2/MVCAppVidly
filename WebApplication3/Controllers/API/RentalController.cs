using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;

namespace WebApplication3.Controllers.API
{
    [Route("api/Rentals")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        private IMapper _mapper;


        public RentalController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<NewRentalDto>> CreateNewRental(NewRentalDto newRentalDto)
        {

            var customer = _dbContext.Customers.Single(
                c => c.Id == newRentalDto.CustomerId);

            var movies = _dbContext.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("One or more MovieIds are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable <= 0)
                    return BadRequest("Movie is not available.");

                _dbContext.Entry(movie).State = EntityState.Modified;
                movie.NumberAvailable--;

                var rental = new Rental()
                {
                    CustomerId = customer.Id,
                    Customer = customer,
                    MovieId = movie.Id,
                    Movie = movie,
                    DateRented = DateTime.Today
                };

                _dbContext.Rentals.Add(rental);
            }

            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomersRentals), new { customerId = customer.Id }, newRentalDto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewRentalDto>>> GetAllRentals()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<Rental>> GetCustomersRentals(int customerId)
        {
            var rentals = await _dbContext.Rentals
                .Include(r => r.Movie)
                .SingleOrDefaultAsync(c => c.CustomerId == customerId);

            if (rentals is null)
                return NotFound();

            return rentals;
        }

    }
}
