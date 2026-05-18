using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserIDinsideMyUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "AppUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AppUsers");
        }
    }
}
