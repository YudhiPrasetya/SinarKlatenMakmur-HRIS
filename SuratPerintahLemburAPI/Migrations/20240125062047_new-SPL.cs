using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratPerintahLemburAPI.Migrations
{
    public partial class newSPL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SPLDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "NominalOT1",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NominalOT2",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NominalOTTotal",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NominalOT1",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "NominalOT2",
                table: "SuratPerintahLemburs");

            migrationBuilder.DropColumn(
                name: "NominalOTTotal",
                table: "SuratPerintahLemburs");

            migrationBuilder.CreateTable(
                name: "SPLDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuratPerintahLemburId = table.Column<int>(type: "int", nullable: false),
                    LemburKe = table.Column<int>(type: "int", nullable: true),
                    NominalLembur = table.Column<int>(type: "int", nullable: true),
                    SPLId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPLDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPLDetails_SuratPerintahLemburs_SuratPerintahLemburId",
                        column: x => x.SuratPerintahLemburId,
                        principalTable: "SuratPerintahLemburs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails",
                column: "SuratPerintahLemburId");
        }
    }
}
