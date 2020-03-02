using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class changeinrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "grade",
                table: "Grades",
                newName: "Grade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Grades",
                newName: "grade");
        }
    }
}
