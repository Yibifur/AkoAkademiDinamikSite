using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_03092 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormOptions_FormElements_FormElementId",
                table: "FormOptions");

            migrationBuilder.AlterColumn<int>(
                name: "FormElementId",
                table: "FormOptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FormOptions_FormElements_FormElementId",
                table: "FormOptions",
                column: "FormElementId",
                principalTable: "FormElements",
                principalColumn: "FormElementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormOptions_FormElements_FormElementId",
                table: "FormOptions");

            migrationBuilder.AlterColumn<int>(
                name: "FormElementId",
                table: "FormOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FormOptions_FormElements_FormElementId",
                table: "FormOptions",
                column: "FormElementId",
                principalTable: "FormElements",
                principalColumn: "FormElementId");
        }
    }
}
