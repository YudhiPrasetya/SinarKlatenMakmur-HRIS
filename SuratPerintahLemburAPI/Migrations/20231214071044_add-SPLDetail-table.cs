using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratPerintahLemburAPI.Migrations
{
    public partial class addSPLDetailtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpahLembur",
                table: "SuratPerintahLemburs");

            migrationBuilder.CreateTable(
                name: "SPLDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalUpahLembur = table.Column<int>(type: "int", nullable: true),
                    SuratPerintahLemburId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "HitunganLembur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LemburKe = table.Column<int>(type: "int", nullable: true),
                    JumlahUang = table.Column<int>(type: "int", nullable: true),
                    SPLDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitunganLembur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HitunganLembur_SPLDetails_SPLDetailId",
                        column: x => x.SPLDetailId,
                        principalTable: "SPLDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HitunganLembur_SPLDetailId",
                table: "HitunganLembur",
                column: "SPLDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails",
                column: "SuratPerintahLemburId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HitunganLembur");

            migrationBuilder.DropTable(
                name: "SPLDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "UpahLembur",
                table: "SuratPerintahLemburs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
