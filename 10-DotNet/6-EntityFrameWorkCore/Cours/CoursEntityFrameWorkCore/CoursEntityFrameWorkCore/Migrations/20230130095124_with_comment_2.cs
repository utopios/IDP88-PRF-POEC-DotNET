using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    /// <inheritdoc />
    public partial class withcomment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_car_CarId",
                table: "comment");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "comment",
                newName: "car_id");

            migrationBuilder.RenameIndex(
                name: "IX_comment_CarId",
                table: "comment",
                newName: "IX_comment_car_id");

            migrationBuilder.AlterColumn<int>(
                name: "car_id",
                table: "comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_car_car_id",
                table: "comment",
                column: "car_id",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_car_car_id",
                table: "comment");

            migrationBuilder.RenameColumn(
                name: "car_id",
                table: "comment",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_comment_car_id",
                table: "comment",
                newName: "IX_comment_CarId");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_car_CarId",
                table: "comment",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id");
        }
    }
}
