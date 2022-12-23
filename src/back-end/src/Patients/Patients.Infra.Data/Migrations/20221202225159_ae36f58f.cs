using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Patients.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ae36f58f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Paciente");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Paciente",
                newName: "Tipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Paciente",
                newName: "Cpf");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "text",
                nullable: true);
        }
    }
}
