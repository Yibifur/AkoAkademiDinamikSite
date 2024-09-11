using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_1109v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormAnswers_FormElements_FormElementId",
                table: "FormAnswers");

            migrationBuilder.DropIndex(
                name: "IX_FormAnswers_FormElementId",
                table: "FormAnswers");

            migrationBuilder.DropColumn(
                name: "FormElementId",
                table: "FormAnswers");

            migrationBuilder.AddColumn<int>(
                name: "FormAnswerId",
                table: "FormElements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormElements_FormAnswerId",
                table: "FormElements",
                column: "FormAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormElements_FormAnswers_FormAnswerId",
                table: "FormElements",
                column: "FormAnswerId",
                principalTable: "FormAnswers",
                principalColumn: "FormAnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormElements_FormAnswers_FormAnswerId",
                table: "FormElements");

            migrationBuilder.DropIndex(
                name: "IX_FormElements_FormAnswerId",
                table: "FormElements");

            migrationBuilder.DropColumn(
                name: "FormAnswerId",
                table: "FormElements");

            migrationBuilder.AddColumn<int>(
                name: "FormElementId",
                table: "FormAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FormAnswers_FormElementId",
                table: "FormAnswers",
                column: "FormElementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FormAnswers_FormElements_FormElementId",
                table: "FormAnswers",
                column: "FormElementId",
                principalTable: "FormElements",
                principalColumn: "FormElementId");
        }
    }
}
