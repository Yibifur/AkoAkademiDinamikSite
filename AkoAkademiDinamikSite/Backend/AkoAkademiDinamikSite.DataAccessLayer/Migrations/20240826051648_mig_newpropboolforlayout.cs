using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    public partial class mig_newpropboolforlayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Layouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Layouts");
        }
    }
}
