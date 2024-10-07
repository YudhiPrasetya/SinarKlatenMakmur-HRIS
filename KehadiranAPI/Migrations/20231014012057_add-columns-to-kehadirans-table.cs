using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KehadiranAPI.Migrations
{
    public partial class addcolumnstokehadiranstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "JadwalMasuk",
                table: "Kehadirans",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "JadwalPulang",
                table: "Kehadirans",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeteranganMasuk",
                table: "Kehadirans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KeteranganMasukId",
                table: "Kehadirans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JadwalMasuk",
                table: "Kehadirans");

            migrationBuilder.DropColumn(
                name: "JadwalPulang",
                table: "Kehadirans");

            migrationBuilder.DropColumn(
                name: "KeteranganMasuk",
                table: "Kehadirans");

            migrationBuilder.DropColumn(
                name: "KeteranganMasukId",
                table: "Kehadirans");
        }
    }
}
