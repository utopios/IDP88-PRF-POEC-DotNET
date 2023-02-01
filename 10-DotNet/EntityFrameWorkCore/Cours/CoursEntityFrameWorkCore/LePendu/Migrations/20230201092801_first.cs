using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePendu.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pendu_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(max)", nullable: false),
                    pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pendu_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "word",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wordvalue = table.Column<string>(name: "word_value", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_word", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PenduUserWord",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    WordsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenduUserWord", x => new { x.UsersId, x.WordsId });
                    table.ForeignKey(
                        name: "FK_PenduUserWord_pendu_user_UsersId",
                        column: x => x.UsersId,
                        principalTable: "pendu_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PenduUserWord_word_WordsId",
                        column: x => x.WordsId,
                        principalTable: "word",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PenduUserWord_WordsId",
                table: "PenduUserWord",
                column: "WordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PenduUserWord");

            migrationBuilder.DropTable(
                name: "pendu_user");

            migrationBuilder.DropTable(
                name: "word");
        }
    }
}
