using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftAPI.Migrations
{
    public partial class addPembagiPayrollcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PembagiPayroll",
                table: "JamKerjas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PembagiPayroll",
                table: "JamKerjas");
        }
    }
}
