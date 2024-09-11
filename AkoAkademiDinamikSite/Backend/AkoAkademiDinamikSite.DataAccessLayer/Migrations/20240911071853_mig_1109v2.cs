using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_1109v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormAnswers",
                columns: table => new
                {
                    FormAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    FormElementId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAnswers", x => x.FormAnswerId);
                    table.ForeignKey(
                        name: "FK_FormAnswers_FormElements_FormElementId",
                        column: x => x.FormElementId,
                        principalTable: "FormElements",
                        principalColumn: "FormElementId");
                    table.ForeignKey(
                        name: "FK_FormAnswers_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "FormId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormAnswers_FormElementId",
                table: "FormAnswers",
                column: "FormElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormAnswers_FormId",
                table: "FormAnswers",
                column: "FormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormAnswers");
        }
    }
}
