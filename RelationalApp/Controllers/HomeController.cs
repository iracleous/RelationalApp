using Microsoft.AspNetCore.Mvc;
using RelationalApp.Models;
using RelationalApp.Services;
using System.Diagnostics;

namespace RelationalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersoneService _personService  ;

        public HomeController(ILogger<HomeController> logger, 
            IPersoneService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactInfo()
        {
            Person person = new Person()
            {
        
                Name = "Test",
                Category = PersonCategory.PHYSICAL,
                IsAdmin = false,
                RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                Balance = 0,
            };

            Person x = _personService.CreatePerson(person);

            Person? p = _personService.ReadPerson(23);
            return View(p);
        }

        public IActionResult Customers()
        {
            IEnumerable<Person> persons = _personService.ReadPerson().ToList();
            return View(persons);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
