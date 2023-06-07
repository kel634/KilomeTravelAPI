using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KilomeTravelAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RentalItemTypesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RentalItemTypes",
                columns: new[] { "Id", "Enabled", "HasFuel", "Name" },
                values: new object[,]
                {
                    { 1, true, true, "Truck" },
                    { 2, true, true, "Minivan" },
                    { 3, true, true, "Sedan" },
                    { 4, false, true, "Bike" },
                    { 5, false, true, "Boat" },
                    { 6, false, false, "Holiday Cottage" },
                    { 7, false, false, "Hotel Room" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RentalItemTypes",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
