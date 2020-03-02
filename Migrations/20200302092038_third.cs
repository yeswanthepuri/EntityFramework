using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityModule.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentInfo",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StudentInfo",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StudentInfo",
                newName: "StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentInfo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
