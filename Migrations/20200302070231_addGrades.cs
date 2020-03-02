using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class addGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeID",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeID",
                table: "Students");
        }
    }
}
