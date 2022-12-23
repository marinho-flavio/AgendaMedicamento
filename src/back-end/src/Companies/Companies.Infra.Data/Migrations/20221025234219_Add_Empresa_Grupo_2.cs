using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Add_Empresa_Grupo_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoEmpresaId",
                table: "Empresa",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_GrupoEmpresaId",
                table: "Empresa",
                column: "GrupoEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_GrupoEmpresa_GrupoEmpresaId",
                table: "Empresa",
                column: "GrupoEmpresaId",
                principalTable: "GrupoEmpresa",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_GrupoEmpresa_GrupoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_GrupoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "GrupoEmpresaId",
                table: "Empresa");
        }
    }
}
