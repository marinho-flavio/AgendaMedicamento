using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Add_Empresa_Grupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentStep",
                table: "GrupoEmpresa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStep",
                table: "Empresa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmpresaId",
                table: "Empresa",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Empresa_EmpresaId",
                table: "Empresa",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Empresa_EmpresaId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_EmpresaId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CurrentStep",
                table: "GrupoEmpresa");

            migrationBuilder.DropColumn(
                name: "CurrentStep",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Empresa");
        }
    }
}
