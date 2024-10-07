using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KehadiranAPI.Migrations
{
    public partial class removeandalterkehadiransTablecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeteranganMasukId",
                table: "Kehadirans");

            migrationBuilder.AlterColumn<string>(
                name: "KeteranganMasuk",
                table: "Kehadirans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "KeteranganMasuk",
                table: "Kehadirans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeteranganMasukId",
                table: "Kehadirans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
