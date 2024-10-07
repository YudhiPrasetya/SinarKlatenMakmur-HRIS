using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JadwalShiftKaryawans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JadwalMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JadwalPulang = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JadwalShiftKaryawans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JadwalShiftSecurities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JadwalMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JadwalPulang = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JadwalShiftSecurities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JamKerjas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurasiPerHari = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JamKerjas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JadwalShiftKaryawans");

            migrationBuilder.DropTable(
                name: "JadwalShiftSecurities");

            migrationBuilder.DropTable(
                name: "JamKerjas");
        }
    }
}
