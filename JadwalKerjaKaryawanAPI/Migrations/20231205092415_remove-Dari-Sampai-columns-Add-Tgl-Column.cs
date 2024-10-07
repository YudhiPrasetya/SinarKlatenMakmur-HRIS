using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JadwalKerjaKaryawanAPI.Migrations
{
    public partial class removeDariSampaicolumnsAddTglColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TglAkhir",
                table: "JadwalKerjaKaryawans");

            migrationBuilder.RenameColumn(
                name: "TglAwal",
                table: "JadwalKerjaKaryawans",
                newName: "Tgl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tgl",
                table: "JadwalKerjaKaryawans",
                newName: "TglAwal");

            migrationBuilder.AddColumn<DateTime>(
                name: "TglAkhir",
                table: "JadwalKerjaKaryawans",
                type: "datetime2",
                nullable: true);
        }
    }
}
