using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjektSklepButow.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostProdukcjaButow_Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marka = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Rodzaj = table.Column<int>(type: "INTEGER", nullable: false),
                    Kolor = table.Column<int>(type: "INTEGER", nullable: false),
                    Cena = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostProdukcjaButow_Models", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PostProdukcjaButow_Models",
                columns: new[] { "Id", "Cena", "Kolor", "Marka", "Model", "Rodzaj" },
                values: new object[,]
                {
                    { 1, 345, 0, "Adidas", "Gazeli", 0 },
                    { 2, 597, 1, "New Balance", "574", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostProdukcjaButow_Models");
        }
    }
}
