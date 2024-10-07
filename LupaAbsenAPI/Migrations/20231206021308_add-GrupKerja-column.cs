using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LupaAbsenAPI.Migrations
{
    public partial class addGrupKerjacolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GrupKerja",
                table: "LupaAbsens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrupKerja",
                table: "LupaAbsens");
        }
    }
}
