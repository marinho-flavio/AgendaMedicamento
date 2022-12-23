using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Update_Companies_Entitites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "GrupoEmpresaConfiguracao");

            migrationBuilder.DropColumn(
                name: "SetorProprio",
                table: "GrupoEmpresa");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "GrupoEmpresa");

            migrationBuilder.DropColumn(
                name: "TipoTelefone",
                table: "GrupoEmpresa");

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

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SetorProprio",
                table: "GrupoEmpresaConfiguracao",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "GrupoEmpresaContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    TipoTelefone = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoEmpresaContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupoEmpresaContacts_GrupoEmpresa_Id",
                        column: x => x.Id,
                        principalTable: "GrupoEmpresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco");

            migrationBuilder.DropTable(
                name: "GrupoEmpresaContacts");

            migrationBuilder.DropColumn(
                name: "SetorProprio",
                table: "GrupoEmpresaConfiguracao");

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

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SetorProprio",
                table: "GrupoEmpresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "GrupoEmpresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoTelefone",
                table: "GrupoEmpresa",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoEmpresaEndereco_Endereco_EnderecoId",
                table: "GrupoEmpresaEndereco",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id");
        }
    }
}
