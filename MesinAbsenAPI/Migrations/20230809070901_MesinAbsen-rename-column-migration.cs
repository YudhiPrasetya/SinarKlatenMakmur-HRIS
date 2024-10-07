using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesinAbsenAPI.Migrations
{
    public partial class MesinAbsenrenamecolumnmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceDecs",
                table: "MesinAbsens",
                newName: "DeviceDesc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceDesc",
                table: "MesinAbsens",
                newName: "DeviceDecs");
        }
    }
}
