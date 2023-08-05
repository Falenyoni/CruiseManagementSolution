using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruiseManagement.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAgents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AdultPax = table.Column<int>(type: "int", nullable: false),
                    ChildPax = table.Column<int>(type: "int", nullable: false),
                    CompPax = table.Column<int>(type: "int", nullable: false),
                    PickupPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdultPrice = table.Column<int>(type: "int", nullable: false),
                    ChildPrice = table.Column<int>(type: "int", nullable: false),
                    CompPrice = table.Column<int>(type: "int", nullable: false),
                    Travelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AgentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Company" },
                    { 2, "Walk-In" }
                });

            migrationBuilder.InsertData(
                table: "BookingAgents",
                columns: new[] { "Id", "AgentName", "AgentTypeId" },
                values: new object[,]
                {
                    { 1, "Shearwater Adventures", 1 },
                    { 2, "Veneto", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cruise" },
                    { 2, "Tours" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A kit provided by Glossier, containing skin care, hair care and makeup products", "Ra Ikani", 100m },
                    { 2, 1, "A kit provided by Curology, containing skin care products", "River Odyssey", 50m }
                });

            migrationBuilder.InsertData(
                table: "ReservationItems",
                columns: new[] { "Id", "AdultPax", "AdultPrice", "ChildPax", "ChildPrice", "CompPax", "CompPrice", "Destination", "PickupPoint", "ProductId", "ReservationId", "Travelled" },
                values: new object[,]
                {
                    { 1, 3, 40, 2, 20, 1, 16, "Cruise", "Elephant Hills Hotel", 2, 1, false },
                    { 2, 10, 60, 5, 50, 4, 30, "Cruise", "Elephant Hills Hotel", 1, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AgentId", "FirstName", "LastName", "MiddleName", "Notes", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Bongani", "Nyoni", "Fale", "", 1 },
                    { 2, 2, "Test 2", "Test", "Test", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Emily" },
                    { 2, "Bongani" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentTypes");

            migrationBuilder.DropTable(
                name: "BookingAgents");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ReservationItems");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
