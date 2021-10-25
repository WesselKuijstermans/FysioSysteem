using DomainModel.Models;
using FysioSysteem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FysioSysteem.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }
        [HttpGet]
        public ViewResult Form() {
            return View();
        }
        [HttpPost]
        public ViewResult Form(PatientViewModel model) { 
            
            if (ModelState.IsValid) {
                PatientModel newPatient = new();
                return View("FormSubmitConfirmation"); 
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}