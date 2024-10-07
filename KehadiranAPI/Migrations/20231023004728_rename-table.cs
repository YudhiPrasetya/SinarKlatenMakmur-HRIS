using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KehadiranAPI.Migrations
{
    public partial class renametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kehadirans");

            migrationBuilder.CreateTable(
                name: "AbsenMasuks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JamMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JadwalMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    KeteranganMasuk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenMasuks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsenMasuks");

            migrationBuilder.CreateTable(
                name: "Kehadirans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JadwalMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JamMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    KeteranganMasuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kehadirans", x => x.Id);
                });
        }
    }
}
