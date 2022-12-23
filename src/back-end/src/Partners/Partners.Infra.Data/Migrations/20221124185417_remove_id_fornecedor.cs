using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Partners.Infra.Data.Migrations
{
    public partial class remove_id_fornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicitario_Fornecedor_FornecedorId",
                table: "Publicitario");

            migrationBuilder.DropColumn(
                name: "IdFornecedor",
                table: "Publicitario");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Publicitario",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicitario_Fornecedor_FornecedorId",
                table: "Publicitario",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicitario_Fornecedor_FornecedorId",
                table: "Publicitario");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Publicitario",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "IdFornecedor",
                table: "Publicitario",
                type: "integer",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicitario_Fornecedor_FornecedorId",
                table: "Publicitario",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id");
        }
    }
}
