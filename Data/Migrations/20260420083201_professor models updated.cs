using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Data.Migrations
{
    /// <inheritdoc />
    public partial class professormodelsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_Courses_CoursesId",
                table: "CourseProfessor");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_MyUsers_ProfessorsId",
                table: "CourseProfessor");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_MyUsers_studentId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_studentId",
                table: "Registrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers");

            migrationBuilder.DropColumn(
                name: "studentId",
                table: "Registrations");

            migrationBuilder.RenameTable(
                name: "MyUsers",
                newName: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "LogoType",
                table: "Degrees",
                newName: "Logotype");

            migrationBuilder.RenameColumn(
                name: "ProfessorsId",
                table: "CourseProfessor",
                newName: "ProfessorsListId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseProfessor",
                newName: "CoursesListId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessor_ProfessorsId",
                table: "CourseProfessor",
                newName: "IX_CourseProfessor_ProfessorsListId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "AppUsers",
                newName: "RegistrationDate");

            migrationBuilder.AddColumn<int>(
                name: "DegreeFK",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "TuitionFee",
                table: "AppUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "AppUsers",
                type: "TEXT",
                maxLength: 19,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 17);

            migrationBuilder.AddColumn<int>(
                name: "DegreeFK",
                table: "AppUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DegreeFK",
                table: "Courses",
                column: "DegreeFK");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_DegreeFK",
                table: "AppUsers",
                column: "DegreeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Degrees_DegreeFK",
                table: "AppUsers",
                column: "DegreeFK",
                principalTable: "Degrees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_AppUsers_ProfessorsListId",
                table: "CourseProfessor",
                column: "ProfessorsListId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_Courses_CoursesListId",
                table: "CourseProfessor",
                column: "CoursesListId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Degrees_DegreeFK",
                table: "Courses",
                column: "DegreeFK",
                principalTable: "Degrees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_AppUsers_StudentFK",
                table: "Registrations",
                column: "StudentFK",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Degrees_DegreeFK",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_AppUsers_ProfessorsListId",
                table: "CourseProfessor");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessor_Courses_CoursesListId",
                table: "CourseProfessor");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Degrees_DegreeFK",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_AppUsers_StudentFK",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DegreeFK",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_DegreeFK",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "DegreeFK",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DegreeFK",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "MyUsers");

            migrationBuilder.RenameColumn(
                name: "Logotype",
                table: "Degrees",
                newName: "LogoType");

            migrationBuilder.RenameColumn(
                name: "ProfessorsListId",
                table: "CourseProfessor",
                newName: "ProfessorsId");

            migrationBuilder.RenameColumn(
                name: "CoursesListId",
                table: "CourseProfessor",
                newName: "CoursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessor_ProfessorsListId",
                table: "CourseProfessor",
                newName: "IX_CourseProfessor_ProfessorsId");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "MyUsers",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "Registrations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "TuitionFee",
                table: "MyUsers",
                type: "decimal(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "MyUsers",
                type: "TEXT",
                maxLength: 17,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 19,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_studentId",
                table: "Registrations",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_Courses_CoursesId",
                table: "CourseProfessor",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessor_MyUsers_ProfessorsId",
                table: "CourseProfessor",
                column: "ProfessorsId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_MyUsers_studentId",
                table: "Registrations",
                column: "studentId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
