using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    /// <inheritdoc />
    public partial class accessory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessoryCar",
                columns: table => new
                {
                    AccessoriesId = table.Column<int>(type: "int", nullable: false),
                    CarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryCar", x => new { x.AccessoriesId, x.CarsId });
                    table.ForeignKey(
                        name: "FK_AccessoryCar_Accessory_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessoryCar_car_CarsId",
                        column: x => x.CarsId,
                        principalTable: "car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryCar_CarsId",
                table: "AccessoryCar",
                column: "CarsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessoryCar");

            migrationBuilder.DropTable(
                name: "Accessory");
        }
    }
}
