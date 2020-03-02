using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class changeinrelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Grades");

            migrationBuilder.AddColumn<int>(
                name: "GradesGradeId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradesGradeId",
                table: "Students",
                column: "GradesGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradesGradeId",
                table: "Students",
                column: "GradesGradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradesGradeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradesGradeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradesGradeId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
