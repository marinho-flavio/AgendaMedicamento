using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Partners.Infra.Data.Migrations
{
    public partial class Add_Companies_Professionals_Partners_Relations_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Publicitario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Fornecedor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Publicitario_EmpresaId",
                table: "Publicitario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EmpresaId",
                table: "Fornecedor",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Empresa_EmpresaId",
                table: "Fornecedor",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicitario_Empresa_EmpresaId",
                table: "Publicitario",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Empresa_EmpresaId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicitario_Empresa_EmpresaId",
                table: "Publicitario");

            migrationBuilder.DropIndex(
                name: "IX_Publicitario_EmpresaId",
                table: "Publicitario");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_EmpresaId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Publicitario");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Fornecedor");
        }
    }
}
