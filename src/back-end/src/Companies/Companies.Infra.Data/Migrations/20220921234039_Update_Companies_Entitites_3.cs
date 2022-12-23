using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Update_Companies_Entitites_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco");

            migrationBuilder.AlterColumn<string>(
                name: "TipoEndereco",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "GrupoEmpresaEndereco",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco");

            migrationBuilder.AlterColumn<string>(
                name: "TipoEndereco",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "GrupoEmpresaEndereco",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "GrupoEmpresaEndereco",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
