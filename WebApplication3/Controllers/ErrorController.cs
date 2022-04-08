using System.Web.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace WebApplication3.Controllers
{
    [Microsoft.AspNetCore.Authorization.AllowAnonymous]
    public class ErrorController : Controller
    {
        [Microsoft.AspNetCore.Mvc.Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, but the resource you requested could not be found.";
                    break;
            }

            return View("Errors/404");
        }

        [Microsoft.AspNetCore.Mvc.Route("Error")]
        public IActionResult Error()
        {
            var exeptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            return View("Errors/Error");
        }
    }
}
