using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace recode_work_api.Migrations
{
    /// <inheritdoc />
    public partial class recodeapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destiny = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Boarding = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Promotion = table.Column<double>(type: "double", nullable: false),
                    Date = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "trips",
                columns: new[] { "Id", "Boarding", "Date", "Description", "Destiny", "Price", "Promotion" },
                values: new object[,]
                {
                    { 1, "Rio de janeiro/Brasil", "2023-10-5", "Viajem internacional", "Berlim/Alemanha", 150.0, 0.80000000000000004 },
                    { 2, "São Paulo/Brasil", "2023-01-12", "Viajem internacional", "Tóquio/Japão", 500.0, 0.84999999999999998 },
                    { 3, "Rio de janeiro/Brazil", "2023-12-7", "Viajem internacional", "Berlim/Alemanha", 100.0, 1.0 },
                    { 4, "Rio branco/Brasil", "2023-02-30", "Viajem internacional", "Porto/Portugal", 150.0, 0.75 },
                    { 5, "Florianopólis/Brasil", "2023-08-10", "Viajem internacional", "Nova Yorque/Estados Unidos", 850.0, 0.94999999999999996 },
                    { 6, "Rio de janeiro/Brazil", "2023-02-20", "Viajem internacional", "Buenos Ares/Argentina", 100.5, 0.84999999999999998 },
                    { 7, "Gramados/Brasil", "2023-04-25", "Viajem internacional", "Madri/Espanha", 650.0, 0.75 },
                    { 8, "Rio de janeiro/Brazil", "2023-07-5", "Viajem internacional", "Berlim/Alemanha", 100.0, 0.80000000000000004 },
                    { 9, "Salvador/Brasil", "2023-08-12", "Viajem internacional", "Capital da Angola/Angola", 250.0, 0.90000000000000002 },
                    { 10, "Vitória/Brazil", "2023-12-15", "Viajem internacional", "Paris/França", 725.0, 0.84999999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trips");
        }
    }
}
