using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftAPI.Migrations
{
    public partial class addcolumninitialtoJadwalShiftSecuritytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Initial",
                table: "JadwalShiftSecurities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Initial",
                table: "JadwalShiftSecurities");
        }
    }
}
