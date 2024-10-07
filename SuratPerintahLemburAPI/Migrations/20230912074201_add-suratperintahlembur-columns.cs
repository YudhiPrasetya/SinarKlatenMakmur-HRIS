using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratperintahLemburAPI.Migrations
{
    public partial class addsuratperintahlemburcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAT",
                table: "SuratPerintahLemburs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "UpdatedAT",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SuratPerintahLemburs");
        }
    }
}
