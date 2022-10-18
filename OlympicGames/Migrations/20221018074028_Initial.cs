using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicGames.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FlagUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "IN", "Indoor" },
                    { "OUT", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { "PARA", "Paralympics" },
                    { "SUMMER", "Summer Olympics" },
                    { "WINTER", "Winter Olympics" },
                    { "YOUTH", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryId", "FlagUrl", "GameId", "Name", "Sport" },
                values: new object[,]
                {
                    { "AUT", "OUT", "austria.png", "PARA", "Austria", "Canoe Sprint" },
                    { "BRA", "OUT", "brazil.png", "SUMMER", "Brazil", "Road Cycling" },
                    { "CAN", "IN", "canada.png", "WINTER", "Canada", "Curling" },
                    { "CHN", "IN", "china.png", "SUMMER", "China", "Diving" },
                    { "CYP", "IN", "cyprus.png", "YOUTH", "Cyprus", "Breakdancing" },
                    { "DEU", "IN", "germany.png", "SUMMER", "Germany", "Diving" },
                    { "FIN", "OUT", "finland.png", "YOUTH", "Finland", "Skateboarding" },
                    { "FRA", "IN", "france.png", "YOUTH", "France", "Breakdancing" },
                    { "GBR", "IN", "united-kingdom.png", "WINTER", "Great Britian", "Curling" },
                    { "ITA", "OUT", "italy.png", "WINTER", "Italy", "Bobsleigh" },
                    { "JAM", "OUT", "jamaica.png", "WINTER", "Jamaica", "Bobsleigh" },
                    { "JPN", "OUT", "japan.png", "WINTER", "Japan", "Bobsleigh" },
                    { "MEX", "IN", "mexico.png", "SUMMER", "Mexico", "Diving" },
                    { "NLD", "OUT", "netherlands.png", "SUMMER", "Netherlands", "Road Cycling" },
                    { "PAK", "OUT", "pakistan.png", "PARA", "Pakistan", "Canoe Sprint" },
                    { "PRT", "OUT", "portugal.png", "YOUTH", "Portugal", "Skateboarding" },
                    { "RUS", "IN", "russia.png", "YOUTH", "Russia", "Breakdancing" },
                    { "SVK", "OUT", "slovakia.png", "YOUTH", "Slovakia", "Skateboarding" },
                    { "SWE", "IN", "sweden.png", "WINTER", "Sweden", "Curling" },
                    { "THA", "IN", "thailand.png", "PARA", "Thailand", "Archery" },
                    { "UKR", "IN", "ukraine.png", "PARA", "Ukraine", "Archery" },
                    { "URY", "IN", "uruguay.png", "PARA", "Uruguay", "Archery" },
                    { "USA", "OUT", "united-states-of-america.png", "SUMMER", "United States of America", "Road Cycling" },
                    { "ZWE", "OUT", "zimbabwe.png", "PARA", "Zimbabwe", "Canoe Sprint" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryId",
                table: "Countries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameId",
                table: "Countries",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
