using ActionFilterExampleAntiXss.Filters;
using ActionFilterExampleAntiXss.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionFilterExampleAntiXss.Controllers
{
    [ServiceFilter(typeof(ActionFilterExample))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]       
        public IActionResult NewCustomer(NewCustomerViewModel model)
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}