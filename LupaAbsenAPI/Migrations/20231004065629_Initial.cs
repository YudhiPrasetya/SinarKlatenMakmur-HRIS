using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LupaAbsenAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LupaAbsens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanggal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaKaryawan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Absen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jam = table.Column<TimeSpan>(type: "time", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LupaAbsens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LupaAbsens");
        }
    }
}
