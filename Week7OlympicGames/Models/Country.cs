using System.ComponentModel.DataAnnotations;

namespace Week6OlympicGames.Models
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public string Sport { get; set; }
        public Category Category { get; set; }
        public String FlagUrl { get; set; }
    }
}