using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class addemployeeidcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "GajiDanTunjangans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "GajiDanTunjangans");
        }
    }
}
