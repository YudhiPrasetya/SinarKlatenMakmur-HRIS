using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class addcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "GajiDanTunjangans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "GajiDanTunjangans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "GajiDanTunjangans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "GajiDanTunjangans");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "GajiDanTunjangans");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "GajiDanTunjangans");
        }
    }
}
