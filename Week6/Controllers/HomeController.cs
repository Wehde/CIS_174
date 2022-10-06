using Week6.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;


namespace Week6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private StudentContext context;
        public HomeController(ILogger<HomeController> logger, StudentContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        public IActionResult Assignments(int id)
        {
            ViewBag.level = id;

            var students = context.Students.OrderBy(s => s.LastName).ToList();

            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}