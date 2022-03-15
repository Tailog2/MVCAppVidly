using System.Linq;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;
using Microsoft.AspNetCore.Http.Extensions;

namespace WebApplication3.Controllers.API
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustomersController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>>  GetCustomers()
        {
            var customersInDb = await _dbContext.Customers.Include(c => c.MembershipType).ToListAsync();
            var customerDto = customersInDb.Select(_mapper.Map<Customer, CustomerDto>).ToList();

            return customerDto;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {
            var customer = await _dbContext.Customers.Include(c => c.MembershipType).SingleOrDefaultAsync(c => c.Id == id);

            if (customer is null)
                return NotFound();

            return _mapper.Map<Customer, CustomerDto>(customer);
        }

        //[ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);

            _dbContext.Customers.Add(customer);
            await  _dbContext.SaveChangesAsync();
            customerDto.Id = customer.Id;

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customerDto);
        }

        //[ValidateAntiForgeryToken]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (id != customerDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var customerInDb = _dbContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _dbContext.Entry(customerInDb).State = EntityState.Modified;

            _mapper.Map(customerDto, customerInDb);

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
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customerInDb = await _dbContext.Customers.FindAsync(id);

            if (customerInDb == null)
                return NotFound();

            _dbContext.Customers.Remove(customerInDb);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
