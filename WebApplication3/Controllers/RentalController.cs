using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace WebApplication3.Controllers
{
    public class RentalController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
