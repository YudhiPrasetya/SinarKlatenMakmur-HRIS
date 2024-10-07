using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JadwalKerjaKaryawanAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JadwalKerjaKaryawans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaKaryawan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglAwal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TglAkhir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JamMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JamPulang = table.Column<TimeSpan>(type: "time", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JadwalKerjaKaryawans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JadwalKerjaKaryawans");
        }
    }
}
