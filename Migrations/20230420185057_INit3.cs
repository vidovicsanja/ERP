using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poslasticarnica.Migrations
{
    public partial class INit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PID",
                table: "StavkaPorudzbine",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PPID",
                table: "StavkaPorudzbine",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PRID",
                table: "SastojakProizvoda",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SID",
                table: "SastojakProizvoda",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "KID",
                table: "Porudzbina",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PID",
                table: "StavkaPorudzbine");

            migrationBuilder.DropColumn(
                name: "PPID",
                table: "StavkaPorudzbine");

            migrationBuilder.DropColumn(
                name: "PRID",
                table: "SastojakProizvoda");

            migrationBuilder.DropColumn(
                name: "SID",
                table: "SastojakProizvoda");

            migrationBuilder.DropColumn(
                name: "KID",
                table: "Porudzbina");
        }
    }
}
