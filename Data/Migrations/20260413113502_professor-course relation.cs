using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Data.Migrations
{
    /// <inheritdoc />
    public partial class professorcourserelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseProfessor",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfessorsId = table.Column<int>(type: "INTEGER", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_CourseProfessor",
                        x => new { x.CoursesId, x.ProfessorsId }
                    );
                    table.ForeignKey(
                        name: "FK_CourseProfessor_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CourseProfessor_MyUsers_ProfessorsId",
                        column: x => x.ProfessorsId,
                        principalTable: "MyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_CourseProfessor_ProfessorsId",
                table: "CourseProfessor",
                column: "ProfessorsId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "CourseProfessor");
        }
    }
}
