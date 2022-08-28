using FirstResponsiveWebAppWehde.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppWehde.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(GetAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.CaclulateAge();
            }
            else
            {
                ViewBag.Age = 0;
            }
            return View(model);
        }
    }
}