using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class changingrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Grades");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Grades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Grades");

            migrationBuilder.AddColumn<int>(
                name: "GradeID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
