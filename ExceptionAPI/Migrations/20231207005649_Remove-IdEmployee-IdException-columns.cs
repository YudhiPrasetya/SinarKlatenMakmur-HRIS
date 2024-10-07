using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceptionAPI.Migrations
{
    public partial class RemoveIdEmployeeIdExceptioncolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmployee",
                table: "Exceptions");

            migrationBuilder.DropColumn(
                name: "IdException",
                table: "Exceptions");

            migrationBuilder.AlterColumn<string>(
                name: "ExceptionName",
                table: "Exceptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Exceptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "GrupKerja",
                table: "Exceptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrupKerja",
                table: "Exceptions");

            migrationBuilder.AlterColumn<string>(
                name: "ExceptionName",
                table: "Exceptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Exceptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmployee",
                table: "Exceptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdException",
                table: "Exceptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
