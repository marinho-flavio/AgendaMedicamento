using System;
using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Professionals.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2022129102214 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profissional",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    CPF = table.Column<string>(type: "text", nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Especialidade = table.Column<string>(type: "text", nullable: true),
                    SubEspecialidade = table.Column<string>(type: "text", nullable: true),
                    CorpoClinico = table.Column<string>(type: "text", nullable: true),
                    CodigoSus = table.Column<string>(type: "text", nullable: true),
                    CodigoCnes = table.Column<string>(type: "text", nullable: true),
                    CboId = table.Column<int>(type: "integer", nullable: true),
                    Convenio = table.Column<string>(type: "text", nullable: true),
                    Escolaridade = table.Column<int>(type: "integer", nullable: true),
                    Funcao = table.Column<string>(type: "text", nullable: true),
                    Cargos = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    UsuarioLogin = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Genero = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profissional_Cbo_CboId",
                        column: x => x.CboId,
                        principalTable: "Cbo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Profissional_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_CboId",
                table: "Profissional",
                column: "CboId");

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_EmpresaId",
                table: "Profissional",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profissional");
        }
    }
}
