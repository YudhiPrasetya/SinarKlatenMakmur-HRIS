using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesinAbsenAPI.Migrations
{
    public partial class AddportColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Port",
                table: "MesinAbsens",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Port",
                table: "MesinAbsens");
        }
    }
}
