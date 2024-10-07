using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KehadiranAPI.Migrations
{
    public partial class removesomecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JadwalPulang",
                table: "Kehadirans");

            migrationBuilder.DropColumn(
                name: "JamPulang",
                table: "Kehadirans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "JadwalPulang",
                table: "Kehadirans",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "JamPulang",
                table: "Kehadirans",
                type: "time",
                nullable: true);
        }
    }
}
