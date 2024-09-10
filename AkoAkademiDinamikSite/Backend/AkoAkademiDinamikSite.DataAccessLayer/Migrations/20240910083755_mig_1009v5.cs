using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_1009v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForElementResponses_FormResponses_FormResponseId",
                table: "ForElementResponses");

            migrationBuilder.AlterColumn<int>(
                name: "FormResponseId",
                table: "ForElementResponses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ForElementResponses_FormResponses_FormResponseId",
                table: "ForElementResponses",
                column: "FormResponseId",
                principalTable: "FormResponses",
                principalColumn: "FormResponseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForElementResponses_FormResponses_FormResponseId",
                table: "ForElementResponses");

            migrationBuilder.AlterColumn<int>(
                name: "FormResponseId",
                table: "ForElementResponses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ForElementResponses_FormResponses_FormResponseId",
                table: "ForElementResponses",
                column: "FormResponseId",
                principalTable: "FormResponses",
                principalColumn: "FormResponseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
