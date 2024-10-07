using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class changeGajiDanTunjanganscolumnsdatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu4",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu3",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu2",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu1",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu4",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu3",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu2",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu1",
                table: "GajiDanTunjangans",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
