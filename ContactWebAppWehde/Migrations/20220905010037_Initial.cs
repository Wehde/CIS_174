using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactWebAppWehde.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "City", "State", "StreetAddress", "Zip" },
                values: new object[] { 1, "Carroll", "IA", "123 Main St.", "51401" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "AddressID", "Email", "Name", "Note", "Phone" },
                values: new object[] { 1, 1, "jdoe@gmail.com", "John Doe", "Example 1", "712-792-1234" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "AddressID", "Email", "Name", "Note", "Phone" },
                values: new object[] { 2, 1, "janedoe@gmail.com", "Jane Doe", "Example 2", "712-792-1235" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressID",
                table: "Contacts",
                column: "AddressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
