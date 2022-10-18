namespace OlympicGames.Models
{
    public class OlympicSession
    {
        private const string COUNTRIES_KEY = "mycountries";
        private const string COUNT_KEY = "countrycount";
        private const string GAME_KEY = "game";
        private const string CATEGORY_KEY = "category";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(COUNTRIES_KEY, countries);
            session.SetInt32(COUNT_KEY, countries.Count);
        }

        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(COUNTRIES_KEY) ?? new List<Country>();

        public int? GetMyCountryCount() => session.GetInt32(COUNT_KEY);

        public void SetActiveGame(string game) =>
            session.SetString(GAME_KEY, game);

        public string GetActiveGame() => session.GetString(GAME_KEY);

        public void SetActiveCategory(string category) =>
            session.SetString(CATEGORY_KEY, category);

        public string GetActiveCategory() => session.GetString(CATEGORY_KEY);

        public void RemoveMyCountries()
        {
            session.Remove(COUNTRIES_KEY);
            session.Remove(COUNT_KEY);
        }
    }

}
