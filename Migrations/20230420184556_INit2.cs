using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poslasticarnica.Migrations
{
    public partial class INit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<long>(
                name: "IDKP",
                table: "Proizvod",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDKP",
                table: "Proizvod");

        }
    }
}
