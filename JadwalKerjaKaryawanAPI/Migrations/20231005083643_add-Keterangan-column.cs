using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JadwalKerjaKaryawanAPI.Migrations
{
    public partial class addKeterangancolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "JadwalKerjaKaryawans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "JadwalKerjaKaryawans");
        }
    }
}
