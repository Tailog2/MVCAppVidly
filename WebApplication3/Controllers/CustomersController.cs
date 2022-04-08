using System.Web.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.ViewModels;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace WebApplication3.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
     
        public IActionResult? Index()
        {
            return View();
        }
        public IActionResult? Details(int id)
        {

            var customer = _dbContext.Customers.Include(c => c.MembershipType).SingleOrDefault( c => c.Id == id);

            if (customer is null)
                return NotFound();

            var viewModel = new CustomerDetailsViewModel() { Customer = customer };
            return View(viewModel);

        }

        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult? Save(Customer customer)
        {
            if (ModelState.IsValid is false)
            {
                var membershipTypes = _dbContext.MembershipTypes.ToList();

                var viewModel = new CustomerFormViewModel(customer)
                {
                    MembershipTypes = membershipTypes
                };

                return View("CustomerForm", viewModel);
            }


            if (customer.Id == 0)
            {
                _dbContext.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _dbContext.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public IActionResult? New()
        {
            var membershipTypes = _dbContext.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);

        }

        public IActionResult Edit(int id)
        {
            var customer = _dbContext.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            var membershipTypes = _dbContext.MembershipTypes.ToList();

            if (customer is null)
                return NotFound();

            var viewModel = new CustomerFormViewModel(customer)
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }
    }
}
