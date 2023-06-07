using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KilomeTravelAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RentalItemsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RentalItems",
                columns: new[] { "Id", "Name", "PricePerDay", "RentalItemTypeId" },
                values: new object[,]
                {
                    { 1, "Duster", 15m, 1 },
                    { 2, "Ford Galaxy", 20m, 2 },
                    { 3, "Dacia 1310", 10m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentalItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RentalItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
