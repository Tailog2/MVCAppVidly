using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 50)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            throw new Exception("Don't worry. This is just a test error");
            return View();
        }
    }
}