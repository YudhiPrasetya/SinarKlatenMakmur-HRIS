using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PositionAPI.Migrations
{
    public partial class renamecolumnPosistinDescToPositionDescinpositiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PosistinDesc",
                table: "Positions",
                newName: "PositionDesc");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "PositionDesc",
                table: "Positions",
                newName: "PosistinDesc");
        }
    }
}
