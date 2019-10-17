using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallmart.Migrations
{
    public partial class novos_campos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerSatisfaction",
                table: "Departamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "Departamentos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerSatisfaction",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "Departamentos");
        }
    }
}
