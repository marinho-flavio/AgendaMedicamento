using System;
using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class ADD_empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_GrupoEmpresa_GrupoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_GrupoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao");

            migrationBuilder.DropColumn(
                name: "GrupoEmpresaId",
                table: "Empresa");

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaContacts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ANS",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Empresa",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNES",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoSUS",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFantasia",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Empresa",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Terceirizado",
                table: "Empresa",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "EmpresaConfiguracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    SetorProprio = table.Column<bool>(type: "boolean", nullable: true),
                    Logo = table.Column<ImageFileInfo>(type: "jsonb", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaConfiguracao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaConfiguracao_Empresa_Id",
                        column: x => x.Id,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    TipoTelefone = table.Column<string>(type: "text", nullable: true),
                    WebSite = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaContacts_Empresa_Id",
                        column: x => x.Id,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaEndereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Referencia = table.Column<string>(type: "text", nullable: true),
                    TipoEndereco = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaEndereco_Empresa_Id",
                        column: x => x.Id,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaEndereco_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaEndereco_EnderecoId",
                table: "EmpresaEndereco",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaConfiguracao");

            migrationBuilder.DropTable(
                name: "EmpresaContacts");

            migrationBuilder.DropTable(
                name: "EmpresaEndereco");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "GrupoEmpresaContacts");

            migrationBuilder.DropColumn(
                name: "ANS",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CNES",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "CodigoSUS",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "NomeFantasia",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Terceirizado",
                table: "Empresa");

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrupoEmpresaId",
                table: "Empresa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_GrupoEmpresaId",
                table: "Empresa",
                column: "GrupoEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_GrupoEmpresa_GrupoEmpresaId",
                table: "Empresa",
                column: "GrupoEmpresaId",
                principalTable: "GrupoEmpresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
