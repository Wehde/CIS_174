using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week6OlympicGames.Migrations
{
    public partial class images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "AUT",
                column: "FlagUrl",
                value: "austria.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "BRA",
                column: "FlagUrl",
                value: "brazil.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CAN",
                column: "FlagUrl",
                value: "canada.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CHN",
                column: "FlagUrl",
                value: "china.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CYP",
                column: "FlagUrl",
                value: "cyprus.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "DEU",
                column: "FlagUrl",
                value: "germany.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "FIN",
                column: "FlagUrl",
                value: "finland.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "FRA",
                column: "FlagUrl",
                value: "france.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "GBR",
                column: "FlagUrl",
                value: "united-kingdom.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ITA",
                column: "FlagUrl",
                value: "italy.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "JAM",
                column: "FlagUrl",
                value: "jamaica.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "JPN",
                column: "FlagUrl",
                value: "japan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "MEX",
                column: "FlagUrl",
                value: "mexico.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "NLD",
                column: "FlagUrl",
                value: "netherlands.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "PAK",
                column: "FlagUrl",
                value: "pakistan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "PRT",
                column: "FlagUrl",
                value: "portugal.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "RUS",
                column: "FlagUrl",
                value: "russia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "SVK",
                column: "FlagUrl",
                value: "slovakia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "SWE",
                column: "FlagUrl",
                value: "sweden.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "THA",
                column: "FlagUrl",
                value: "thailand.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "UKR",
                column: "FlagUrl",
                value: "ukraine.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "URY",
                column: "FlagUrl",
                value: "uruguay.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "USA",
                column: "FlagUrl",
                value: "united-states-of-america.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ZWE",
                column: "FlagUrl",
                value: "zimbabwe.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "AUT",
                column: "FlagUrl",
                value: "./flags/austria.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "BRA",
                column: "FlagUrl",
                value: "./flags/brazil.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CAN",
                column: "FlagUrl",
                value: "./flags/canada.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CHN",
                column: "FlagUrl",
                value: "./flags/china.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "CYP",
                column: "FlagUrl",
                value: "./flags/cyprus.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "DEU",
                column: "FlagUrl",
                value: "./flags/germany.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "FIN",
                column: "FlagUrl",
                value: "./flags/finland.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "FRA",
                column: "FlagUrl",
                value: "./flags/france.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "GBR",
                column: "FlagUrl",
                value: "./flags/united-kingdom.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ITA",
                column: "FlagUrl",
                value: "./flags/italy.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "JAM",
                column: "FlagUrl",
                value: "./flags/jamaica.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "JPN",
                column: "FlagUrl",
                value: "./flags/japan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "MEX",
                column: "FlagUrl",
                value: "./flags/mexico.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "NLD",
                column: "FlagUrl",
                value: "./flags/netherlands.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "PAK",
                column: "FlagUrl",
                value: "./flags/pakistan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "PRT",
                column: "FlagUrl",
                value: "./flags/portugal.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "RUS",
                column: "FlagUrl",
                value: "./flags/russia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "SVK",
                column: "FlagUrl",
                value: "./flags/slovakia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "SWE",
                column: "FlagUrl",
                value: "./flags/sweden.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "THA",
                column: "FlagUrl",
                value: "./flags/thailand.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "UKR",
                column: "FlagUrl",
                value: "./flags/ukraine.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "URY",
                column: "FlagUrl",
                value: "./flags/uruguay.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "USA",
                column: "FlagUrl",
                value: "./flags/united-states-of-america.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ZWE",
                column: "FlagUrl",
                value: "./flags/zimbabwe.png");
        }
    }
}
