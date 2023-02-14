using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "car");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "car",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "car",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "car",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "car",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_car",
                table: "car",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_car",
                table: "car");

            migrationBuilder.RenameTable(
                name: "car",
                newName: "Cars");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cars",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Cars",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cars",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");
        }
    }
}
