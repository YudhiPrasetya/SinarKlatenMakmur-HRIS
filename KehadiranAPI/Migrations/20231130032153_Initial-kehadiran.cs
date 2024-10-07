using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KehadiranAPI.Migrations
{
    public partial class Initialkehadiran : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kehadirans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupKerja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JadwalMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JamMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JadwalPulang = table.Column<TimeSpan>(type: "time", nullable: true),
                    JamPulang = table.Column<TimeSpan>(type: "time", nullable: true),
                    Terlambat = table.Column<TimeSpan>(type: "time", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kehadirans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kehadirans");
        }
    }
}
