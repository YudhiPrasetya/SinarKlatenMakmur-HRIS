using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftAPI.Migrations
{
    public partial class InitialShiftDepartemen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JadwalShiftDepartemens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupKerja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JadwalMasuk = table.Column<TimeSpan>(type: "time", nullable: true),
                    JadwalPulang = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JadwalShiftDepartemens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JadwalShiftDepartemens");
        }
    }
}
