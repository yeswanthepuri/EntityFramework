using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentInfo");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "StudentInfo",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeId",
                table: "StudentInfo",
                newName: "IX_StudentInfo_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StudentInfo",
                type: "ntext",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentInfo",
                table: "StudentInfo",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_StudentInfo_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "StudentInfo",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                table: "StudentInfo",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_StudentInfo_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                table: "StudentInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentInfo",
                table: "StudentInfo");

            migrationBuilder.RenameTable(
                name: "StudentInfo",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfo_GradeId",
                table: "Students",
                newName: "IX_Students_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
