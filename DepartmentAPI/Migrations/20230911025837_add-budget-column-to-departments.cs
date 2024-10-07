using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentAPI.Migrations
{
    public partial class addbudgetcolumntodepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Budget",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Departments");
        }
    }
}
