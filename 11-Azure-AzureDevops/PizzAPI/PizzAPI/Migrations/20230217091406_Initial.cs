using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PizzaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "ImageLink", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "/images/bacon.jpg", "Bacon", 12m },
                    { 2, "/images/cheese.jpg", "4 fromages", 11m },
                    { 3, "/images/margherita.jpg", "Margherita", 10m },
                    { 4, "/images/meaty.jpg", "Mexicaine", 12m },
                    { 5, "/images/mushroom.jpg", "Reine", 11m },
                    { 6, "/images/pepperoni.jpg", "Pepperoni", 11m },
                    { 7, "/images/veggie.jpg", "Végétarienne", 10m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "PizzaId" },
                values: new object[,]
                {
                    { 1, "bacon", 1 },
                    { 2, "mozzarella", 1 },
                    { 3, "champignon", 1 },
                    { 4, "emmental", 1 },
                    { 5, "cantal", 2 },
                    { 6, "mozzarella", 2 },
                    { 7, "fromage de chèvre", 2 },
                    { 8, "gruyère", 2 },
                    { 9, "sauce tomate", 3 },
                    { 10, "mozzarella", 3 },
                    { 11, "basilic", 3 },
                    { 12, "boeuf", 4 },
                    { 13, "mozzarella", 4 },
                    { 14, "maïs", 4 },
                    { 15, "tomates", 4 },
                    { 16, "oignon", 4 },
                    { 17, "coriandre", 4 },
                    { 18, "jambon", 5 },
                    { 19, "champignons", 5 },
                    { 20, "mozzarella", 5 },
                    { 21, "mozzarella", 6 },
                    { 22, "pepperoni", 6 },
                    { 23, "tomates", 6 },
                    { 24, "champignons", 7 },
                    { 25, "roquette", 7 },
                    { 26, "artichauts", 7 },
                    { 27, "aubergine", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaId",
                table: "Ingredients",
                column: "PizzaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
