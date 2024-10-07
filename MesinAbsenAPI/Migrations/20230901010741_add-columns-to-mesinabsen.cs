using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesinAbsenAPI.Migrations
{
    public partial class addcolumnstomesinabsen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "MesinAbsens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MesinAbsens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "MesinAbsens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MesinAbsens");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MesinAbsens");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MesinAbsens");
        }
    }
}
