using System.Diagnostics.Contracts;

namespace Week6OlympicGames.Models
{
    public class CountryListViewModel
    {
        public List<Country> Countries;
        public string ActiveGame;
        public string ActiveCategory;

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Game { GameId = "ALL", Name = "All" });
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0, new Category { CategoryId = "ALL", Name = "All" });
            }
        }

        public string CheckActiveGame(string g) => g.ToUpper() == ActiveGame.ToUpper() ? "active" : "";
        public string CheckActiveCategory(string c) => c.ToUpper() == ActiveCategory.ToUpper() ? "active" : "";
    }
}
