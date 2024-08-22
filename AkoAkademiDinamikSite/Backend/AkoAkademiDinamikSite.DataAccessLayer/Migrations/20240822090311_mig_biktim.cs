using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_biktim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Pages_ParentPageId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ParentPageId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ParentPageId",
                table: "Pages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentPageId",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ParentPageId",
                table: "Pages",
                column: "ParentPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Pages_ParentPageId",
                table: "Pages",
                column: "ParentPageId",
                principalTable: "Pages",
                principalColumn: "PageId");
        }
    }
}
