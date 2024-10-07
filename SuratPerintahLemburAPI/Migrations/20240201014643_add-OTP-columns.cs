using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratPerintahLemburAPI.Migrations
{
    public partial class addOTPcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OTP1",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTP2",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTP3",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTP4",
                table: "SuratPerintahLemburs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OTPNominal1",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OTPNominal2",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OTPNominal3",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OTPNominal4",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OTP1",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTP2",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTP3",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTP4",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTPNominal1",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTPNominal2",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTPNominal3",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "OTPNominal4",
                table: "SuratPerintahLemburs");
        }
    }
}
