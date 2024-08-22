using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_biktim2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "Pages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "ContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "ContentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
