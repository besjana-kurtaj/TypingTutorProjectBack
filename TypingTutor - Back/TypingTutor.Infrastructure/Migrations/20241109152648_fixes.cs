using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypingTutor.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProgresses_Lesson_LessonId",
                table: "UserProgresses");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "UserProgresses",
                newName: "LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProgresses_LessonId",
                table: "UserProgresses",
                newName: "IX_UserProgresses_LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgresses_Levels_LevelId",
                table: "UserProgresses",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProgresses_Levels_LevelId",
                table: "UserProgresses");

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "UserProgresses",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProgresses_LevelId",
                table: "UserProgresses",
                newName: "IX_UserProgresses_LessonId");

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lesson_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_LevelId",
                table: "Lesson",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgresses_Lesson_LessonId",
                table: "UserProgresses",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
