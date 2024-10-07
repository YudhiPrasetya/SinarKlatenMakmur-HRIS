using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class changeUpahColumntype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Upah",
                table: "GajiDanTunjangans",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Upah",
                table: "GajiDanTunjangans",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
