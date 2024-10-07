using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesinAbsenAPI.Migrations
{
    public partial class addDeviceNocolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeviceNo",
                table: "MesinAbsens",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceNo",
                table: "MesinAbsens");
        }
    }
}
