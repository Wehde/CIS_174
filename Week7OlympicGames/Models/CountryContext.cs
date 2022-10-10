using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Week6OlympicGames.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = "WINTER",
                    Name = "Winter Olympics"
                },
                new Game
                {
                    GameId = "SUMMER",
                    Name = "Summer Olympics"
                },
                new Game
                {
                    GameId = "PARA",
                    Name = "Paralympics"
                },
                new Game
                {
                    GameId = "YOUTH",
                    Name = "Youth Olympic Games"
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = "IN",
                    Name = "Indoor"
                },
                new Category
                {
                    CategoryId = "OUT",
                    Name = "Outdoor"
                });
            modelBuilder.Entity<Country>().HasData(
                new
                {
                    CountryId = "CAN",
                    Name = "Canada",
                    GameId = "WINTER",
                    Sport = "Curling",
                    CategoryId = "IN",
                    FlagUrl = "canada.png"
                },
                new
                {
                    CountryId = "SWE",
                    Name = "Sweden",
                    GameId = "WINTER",
                    Sport = "Curling",
                    CategoryId = "IN",
                    FlagUrl = "sweden.png"
                },
                new
                {
                    CountryId = "GBR",
                    Name = "Great Britian",
                    GameId = "WINTER",
                    Sport = "Curling",
                    CategoryId = "IN",
                    FlagUrl = "united-kingdom.png"
                },
                new
                {
                    CountryId = "JAM",
                    Name = "Jamaica",
                    GameId = "WINTER",
                    Sport = "Bobsleigh",
                    CategoryId = "OUT",
                    FlagUrl = "jamaica.png"
                },
                new
                {
                    CountryId = "ITA",
                    Name = "Italy",
                    GameId = "WINTER",
                    Sport = "Bobsleigh",
                    CategoryId = "OUT",
                    FlagUrl = "italy.png"
                },
                new
                {
                    CountryId = "JPN",
                    Name = "Japan",
                    GameId = "WINTER",
                    Sport = "Bobsleigh",
                    CategoryId = "OUT",
                    FlagUrl = "japan.png"
                },
                new
                {
                    CountryId = "DEU",
                    Name = "Germany",
                    GameId = "SUMMER",
                    Sport = "Diving",
                    CategoryId = "IN",
                    FlagUrl = "germany.png"
                },
                new
                {
                    CountryId = "CHN",
                    Name = "China",
                    GameId = "SUMMER",
                    Sport = "Diving",
                    CategoryId = "IN",
                    FlagUrl = "china.png"
                },
                new
                {
                    CountryId = "MEX",
                    Name = "Mexico",
                    GameId = "SUMMER",
                    Sport = "Diving",
                    CategoryId = "IN",
                    FlagUrl = "mexico.png"
                },
                new
                {
                    CountryId = "BRA",
                    Name = "Brazil",
                    GameId = "SUMMER",
                    Sport = "Road Cycling",
                    CategoryId = "OUT",
                    FlagUrl = "brazil.png"
                },
                new
                {
                    CountryId = "NLD",
                    Name = "Netherlands",
                    GameId = "SUMMER",
                    Sport = "Road Cycling",
                    CategoryId = "OUT",
                    FlagUrl = "netherlands.png"
                },
                new
                {
                    CountryId = "USA",
                    Name = "United States of America",
                    GameId = "SUMMER",
                    Sport = "Road Cycling",
                    CategoryId = "OUT",
                    FlagUrl = "united-states-of-america.png"
                },
                new
                {
                    CountryId = "THA",
                    Name = "Thailand",
                    GameId = "PARA",
                    Sport = "Archery",
                    CategoryId = "IN",
                    FlagUrl = "thailand.png"
                },
                new
                {
                    CountryId = "URY",
                    Name = "Uruguay",
                    GameId = "PARA",
                    Sport = "Archery",
                    CategoryId = "IN",
                    FlagUrl = "uruguay.png"
                },
                new
                {
                    CountryId = "UKR",
                    Name = "Ukraine",
                    GameId = "PARA",
                    Sport = "Archery",
                    CategoryId = "IN",
                    FlagUrl = "ukraine.png"
                },
                new
                {
                    CountryId = "AUT",
                    Name = "Austria",
                    GameId = "PARA",
                    Sport = "Canoe Sprint",
                    CategoryId = "OUT",
                    FlagUrl = "austria.png"
                },
                new
                {
                    CountryId = "PAK",
                    Name = "Pakistan",
                    GameId = "PARA",
                    Sport = "Canoe Sprint",
                    CategoryId = "OUT",
                    FlagUrl = "pakistan.png"
                },
                new
                {
                    CountryId = "ZWE",
                    Name = "Zimbabwe",
                    GameId = "PARA",
                    Sport = "Canoe Sprint",
                    CategoryId = "OUT",
                    FlagUrl = "zimbabwe.png"
                },
                new
                {
                    CountryId = "FRA",
                    Name = "France",
                    GameId = "YOUTH",
                    Sport = "Breakdancing",
                    CategoryId = "IN",
                    FlagUrl = "france.png"
                },
                new
                {
                    CountryId = "CYP",
                    Name = "Cyprus",
                    GameId = "YOUTH",
                    Sport = "Breakdancing",
                    CategoryId = "IN",
                    FlagUrl = "cyprus.png"
                },
                new
                {
                    CountryId = "RUS",
                    Name = "Russia",
                    GameId = "YOUTH",
                    Sport = "Breakdancing",
                    CategoryId = "IN",
                    FlagUrl = "russia.png"
                },
                new
                {
                    CountryId = "FIN",
                    Name = "Finland",
                    GameId = "YOUTH",
                    Sport = "Skateboarding",
                    CategoryId = "OUT",
                    FlagUrl = "finland.png"
                },
                new
                {
                    CountryId = "SVK",
                    Name = "Slovakia",
                    GameId = "YOUTH",
                    Sport = "Skateboarding",
                    CategoryId = "OUT",
                    FlagUrl = "slovakia.png"
                },
                new
                {
                    CountryId = "PRT",
                    Name = "Portugal",
                    GameId = "YOUTH",
                    Sport = "Skateboarding",
                    CategoryId = "OUT",
                    FlagUrl = "portugal.png"
                }
                );
        }
    }
}
