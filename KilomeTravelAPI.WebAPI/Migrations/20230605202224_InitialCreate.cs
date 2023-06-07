using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KilomeTravelAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clerks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clerks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasFuel = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    RentalItemTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalItems_RentalItemTypes_RentalItemTypeId",
                        column: x => x.RentalItemTypeId,
                        principalTable: "RentalItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RentalItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerPhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentOrders_RentalItems_RentalItemId",
                        column: x => x.RentalItemId,
                        principalTable: "RentalItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentReturns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RentOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReturnTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FuelPenalty = table.Column<decimal>(type: "TEXT", nullable: false),
                    DamagePenalty = table.Column<decimal>(type: "TEXT", nullable: false),
                    DamageDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentReturns_RentOrders_RentOrderId",
                        column: x => x.RentOrderId,
                        principalTable: "RentOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentalItems_RentalItemTypeId",
                table: "RentalItems",
                column: "RentalItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrders_RentalItemId",
                table: "RentOrders",
                column: "RentalItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RentReturns_RentOrderId",
                table: "RentReturns",
                column: "RentOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clerks");

            migrationBuilder.DropTable(
                name: "RentReturns");

            migrationBuilder.DropTable(
                name: "RentOrders");

            migrationBuilder.DropTable(
                name: "RentalItems");

            migrationBuilder.DropTable(
                name: "RentalItemTypes");
        }
    }
}
