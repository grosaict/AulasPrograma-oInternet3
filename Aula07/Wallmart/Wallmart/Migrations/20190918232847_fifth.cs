using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallmart.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerSatisfaction",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerSatisfaction",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "Department");
        }
    }
}
