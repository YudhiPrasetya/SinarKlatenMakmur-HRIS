using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratperintahLemburAPI.Migrations
{
    public partial class SuratPerintahLembur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuratPerintahLemburs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OTType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OTDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OT1 = table.Column<int>(type: "int", nullable: false),
                    OT2 = table.Column<int>(type: "int", nullable: false),
                    OTBreak = table.Column<int>(type: "int", nullable: false),
                    OTTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuratPerintahLemburs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuratPerintahLemburs");
        }
    }
}
