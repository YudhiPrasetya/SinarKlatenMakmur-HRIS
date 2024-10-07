using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class changecolumnsdatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BPJS_Ortu4",
                table: "GajiDanTunjangans",
                type: "decimal(5,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BPJS_Ortu3",
                table: "GajiDanTunjangans",
                type: "decimal(5,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BPJS_Ortu2",
                table: "GajiDanTunjangans",
                type: "decimal(5,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BPJS_Ortu1",
                table: "GajiDanTunjangans",
                type: "decimal(5,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu4",
                table: "GajiDanTunjangans",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu3",
                table: "GajiDanTunjangans",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu2",
                table: "GajiDanTunjangans",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BPJS_Ortu1",
                table: "GajiDanTunjangans",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldNullable: true);
        }
    }
}
