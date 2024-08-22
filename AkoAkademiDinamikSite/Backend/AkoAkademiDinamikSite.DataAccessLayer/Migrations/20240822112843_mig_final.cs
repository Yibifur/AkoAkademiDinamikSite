using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageId",
                table: "Contents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageId",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
