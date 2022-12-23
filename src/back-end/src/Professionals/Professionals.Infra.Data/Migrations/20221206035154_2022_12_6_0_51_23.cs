using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Professionals.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _202212605123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionario",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "Cnpj",
                table: "Funcionario",
                newName: "CNPJ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Funcionario",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "CNPJ",
                table: "Funcionario",
                newName: "Cnpj");
        }
    }
}
