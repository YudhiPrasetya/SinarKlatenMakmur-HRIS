using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuratPerintahLemburAPI.Migrations
{
    public partial class removehitanganlemburtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HitunganLembur");

            migrationBuilder.DropIndex(
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails");

            migrationBuilder.RenameColumn(
                name: "TotalUpahLembur",
                table: "SPLDetails",
                newName: "NominalLembur");

            migrationBuilder.AddColumn<int>(
                name: "LemburKe",
                table: "SPLDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SPLId",
                table: "SPLDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails",
                column: "SuratPerintahLemburId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails");

            migrationBuilder.DropColumn(
                name: "LemburKe",
                table: "SPLDetails");

            migrationBuilder.DropColumn(
                name: "SPLId",
                table: "SPLDetails");

            migrationBuilder.RenameColumn(
                name: "NominalLembur",
                table: "SPLDetails",
                newName: "TotalUpahLembur");

            migrationBuilder.CreateTable(
                name: "HitunganLembur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JumlahUang = table.Column<int>(type: "int", nullable: true),
                    LemburKe = table.Column<int>(type: "int", nullable: true),
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
                name: "IX_SPLDetails_SuratPerintahLemburId",
                table: "SPLDetails",
                column: "SuratPerintahLemburId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HitunganLembur_SPLDetailId",
                table: "HitunganLembur",
                column: "SPLDetailId");
        }
    }
}
