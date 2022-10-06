using Microsoft.AspNetCore.Mvc;

namespace Week6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
