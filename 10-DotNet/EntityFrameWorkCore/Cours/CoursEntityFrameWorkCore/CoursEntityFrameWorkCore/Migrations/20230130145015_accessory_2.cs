using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    /// <inheritdoc />
    public partial class accessory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessoryCar_Accessory_AccessoriesId",
                table: "AccessoryCar");

            migrationBuilder.DropForeignKey(
                name: "FK_AccessoryCar_car_CarsId",
                table: "AccessoryCar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessoryCar",
                table: "AccessoryCar");

            migrationBuilder.RenameColumn(
                name: "CarsId",
                table: "AccessoryCar",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "AccessoriesId",
                table: "AccessoryCar",
                newName: "AccessoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessoryCar_CarsId",
                table: "AccessoryCar",
                newName: "IX_AccessoryCar_CarId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AccessoryCar",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "AccessoryCar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessoryCar",
                table: "AccessoryCar",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryCar_AccessoryId",
                table: "AccessoryCar",
                column: "AccessoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessoryCar_Accessory_AccessoryId",
                table: "AccessoryCar",
                column: "AccessoryId",
                principalTable: "Accessory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccessoryCar_car_CarId",
                table: "AccessoryCar",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessoryCar_Accessory_AccessoryId",
                table: "AccessoryCar");

            migrationBuilder.DropForeignKey(
                name: "FK_AccessoryCar_car_CarId",
                table: "AccessoryCar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessoryCar",
                table: "AccessoryCar");

            migrationBuilder.DropIndex(
                name: "IX_AccessoryCar_AccessoryId",
                table: "AccessoryCar");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccessoryCar");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "AccessoryCar");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "AccessoryCar",
                newName: "CarsId");

            migrationBuilder.RenameColumn(
                name: "AccessoryId",
                table: "AccessoryCar",
                newName: "AccessoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessoryCar_CarId",
                table: "AccessoryCar",
                newName: "IX_AccessoryCar_CarsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessoryCar",
                table: "AccessoryCar",
                columns: new[] { "AccessoriesId", "CarsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AccessoryCar_Accessory_AccessoriesId",
                table: "AccessoryCar",
                column: "AccessoriesId",
                principalTable: "Accessory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccessoryCar_car_CarsId",
                table: "AccessoryCar",
                column: "CarsId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
