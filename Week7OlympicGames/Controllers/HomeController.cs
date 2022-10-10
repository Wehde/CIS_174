using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Week6OlympicGames.Models;

namespace Week6OlympicGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CountryContext context;

        public HomeController(ILogger<HomeController> logger, CountryContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public ViewResult Index(string activeGame = "ALL", string activeCategory = "ALL")
        {
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCategory = activeCategory,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeGame != "ALL")
            {
                query = query.Where(c => c.Game.GameId.ToUpper() == activeGame.ToUpper());
            }
            if (activeCategory != "ALL")
            {
                query = query.Where(c => c.Category.CategoryId.ToUpper() == activeCategory.ToUpper());
            }

            model.Countries = query.OrderBy(c => c.Name).ToList();
            return View(model);
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