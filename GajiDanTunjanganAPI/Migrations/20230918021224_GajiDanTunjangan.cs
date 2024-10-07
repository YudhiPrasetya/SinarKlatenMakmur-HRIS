using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GajiDanTunjanganAPI.Migrations
{
    public partial class GajiDanTunjangan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GajiDanTunjangans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupKerja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaKaryawan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Upah = table.Column<int>(type: "int", nullable: false),
                    PTKP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTKP_Jumlah = table.Column<int>(type: "int", nullable: false),
                    TunjJabatan = table.Column<int>(type: "int", nullable: false),
                    TunjKeterampilan = table.Column<int>(type: "int", nullable: false),
                    TunjMasaKerja = table.Column<int>(type: "int", nullable: false),
                    TunjLain = table.Column<int>(type: "int", nullable: false),
                    PotonganKoperasi = table.Column<int>(type: "int", nullable: false),
                    PotonganLain = table.Column<int>(type: "int", nullable: false),
                    Potong_BPJSKes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potong_BPJSTK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPJS_Ortu1 = table.Column<float>(type: "real", nullable: false),
                    BPJS_Ortu2 = table.Column<float>(type: "real", nullable: false),
                    BPJS_Ortu3 = table.Column<float>(type: "real", nullable: false),
                    BPJS_Ortu4 = table.Column<float>(type: "real", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GajiDanTunjangans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GajiDanTunjangans");
        }
    }
}
