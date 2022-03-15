using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;

namespace WebApplication3.Controllers.API
{
    [Route("api/Movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public MovieController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
        {
            var movieInDb = await _dbContext.Movies.Include(m => m.Genre).ToListAsync();
            var movieDto = movieInDb.Select(_mapper.Map<Movie, MovieDto>).ToList();

            return movieDto;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDto>> GetMovie(int id)
        {
            var movie = await _dbContext.Movies.Include(c => c.Genre).SingleOrDefaultAsync(m => m.Id == id);

            if (movie is null)
                return NotFound();

            return _mapper.Map<Movie, MovieDto>(movie);
        }

        [HttpPost]
        public async Task<ActionResult<MovieDto>> CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var movie = _mapper.Map<MovieDto, Movie>(movieDto);

            _dbContext.Movies.Add(movie);
            await _dbContext.SaveChangesAsync();
            movieDto.Id = movie.Id;

            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movieDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieDto movieDto)
        {
            if (id != movieDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var movieInDb = _dbContext.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return NotFound();

            _dbContext.Entry(movieInDb).State = EntityState.Modified;

            _mapper.Map(movieDto, movieInDb);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movieInDb = await _dbContext.Movies.FindAsync(id);

            if (movieInDb == null)
                return NotFound();

            _dbContext.Movies.Remove(movieInDb);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
