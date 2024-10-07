using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratPerintahLemburAPI.Migrations
{
    public partial class addcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAT",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TunjJabatan",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TunjKeterampilan",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TunjLain",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TunjMasaKerja",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Upah",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TunjJabatan",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "TunjKeterampilan",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "TunjLain",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "TunjMasaKerja",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "Upah",
                table: "SuratPerintahLemburs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAT",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
