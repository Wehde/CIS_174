namespace OlympicGames.Models
{
    public class OlympicCookies
    {
        private const string COUNTRIES_KEY = "mycountries";
        private const string DELIMETER = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public OlympicCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }

        public OlympicCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIds(List<Country> mycountries)
        {
            List<string> ids = mycountries.Select(c => c.CountryId).ToList();
            string idsString = String.Join(DELIMETER, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyCountryIds();
            responseCookies.Append(COUNTRIES_KEY, idsString, options);
        }

        public string[] GetMyCountryIds()
        {
            string cookie = requestCookies[COUNTRIES_KEY];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };
            else
                return cookie.Split(DELIMETER);
        }

        public void RemoveMyCountryIds()
        {
            responseCookies.Delete(COUNTRIES_KEY);
        }
    }
}
