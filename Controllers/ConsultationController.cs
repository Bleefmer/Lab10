using Microsoft.AspNetCore.Mvc;
using lab10.Models;

namespace lab10.Controllers
{
    public class ConsultationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new Consultation());
        }

        [HttpPost]
        public IActionResult Register(Consultation model)
        {
            if (ModelState.IsValid)
            {
                // Process the registration (e.g., save to database)
                return RedirectToAction("Success"); // Redirect to a success page or action
            }

            return View(model); // Return the same view with validation errors
        }

        public IActionResult Success()
        {
            return View(); // A simple view to indicate success
        }
    }
}
