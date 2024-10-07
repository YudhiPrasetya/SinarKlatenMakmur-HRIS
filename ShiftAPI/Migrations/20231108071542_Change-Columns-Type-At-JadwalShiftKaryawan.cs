using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftAPI.Migrations
{
    public partial class ChangeColumnsTypeAtJadwalShiftKaryawan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "JadwalPulang",
                table: "JadwalShiftKaryawans",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "JadwalMasuk",
                table: "JadwalShiftKaryawans",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "JadwalPulang",
                table: "JadwalShiftKaryawans",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JadwalMasuk",
                table: "JadwalShiftKaryawans",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }
    }
}
