using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Add_IsFilial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFilial",
                table: "Empresa",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFilial",
                table: "Empresa");
        }
    }
}
