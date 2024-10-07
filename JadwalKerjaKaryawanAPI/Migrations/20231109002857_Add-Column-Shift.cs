using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JadwalKerjaKaryawanAPI.Migrations
{
    public partial class AddColumnShift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "JadwalKerjaKaryawans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shift",
                table: "JadwalKerjaKaryawans");
        }
    }
}
