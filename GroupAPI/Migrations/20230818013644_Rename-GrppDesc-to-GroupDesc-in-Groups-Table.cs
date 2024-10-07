using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupAPI.Migrations
{
    public partial class RenameGrppDesctoGroupDescinGroupsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrpupDesc",
                table: "Groups",
                newName: "GroupDesc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupDesc",
                table: "Groups",
                newName: "GrpupDesc");
        }
    }
}
