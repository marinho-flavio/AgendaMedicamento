using System;
using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bravo.HealthPlans.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _20221212175853 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Convenio",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoReferencia",
                table: "Convenio",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logomarca",
                table: "Convenio",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Convenio",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PadronizarQuantidadeDigitos",
                table: "Convenio",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDigitos",
                table: "Convenio",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroANS",
                table: "Convenio",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ConvenioHorasEspeciais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dia = table.Column<string>(type: "text", nullable: false),
                    HoraInicial = table.Column<string>(type: "text", nullable: false),
                    HoraFinal = table.Column<string>(type: "text", nullable: false),
                    ConvenioId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvenioHorasEspeciais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConvenioHorasEspeciais_Convenio_ConvenioId",
                        column: x => x.ConvenioId,
                        principalTable: "Convenio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthPlansAggSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true),
                    AutoSaveSettings = table.Column<AutoSaveSettings>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthPlansAggSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthPlansAggSettings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoPlano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPlano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanoConvenio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConvenioId = table.Column<int>(type: "integer", nullable: false),
                    ClassificacaoServicoHospitalar = table.Column<int>(type: "integer", nullable: false),
                    TipoPlanoId = table.Column<int>(type: "integer", nullable: false),
                    MultiplicadorHospitalar = table.Column<decimal>(type: "numeric", nullable: false),
                    MultiplicadorProfissional = table.Column<decimal>(type: "numeric", nullable: false),
                    MultiplicadorExame = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoPercentualPrincipal = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoPrincipalDiferente = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoPrincipalMesma = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoHospitalarPrincipal = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoHospitalarDiferente = table.Column<decimal>(type: "numeric", nullable: false),
                    ProcedimentoHospitalarMesma = table.Column<decimal>(type: "numeric", nullable: false),
                    DescricaoMedicamento = table.Column<string>(type: "text", nullable: false),
                    MoedaMedicamento = table.Column<string>(type: "text", nullable: false),
                    TipoTabelaMedicamento = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoConvenio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoConvenio_Convenio_ConvenioId",
                        column: x => x.ConvenioId,
                        principalTable: "Convenio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanoConvenio_TipoPlano_TipoPlanoId",
                        column: x => x.TipoPlanoId,
                        principalTable: "TipoPlano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConvenioHorasEspeciais_ConvenioId",
                table: "ConvenioHorasEspeciais",
                column: "ConvenioId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthPlansAggSettings_UserId",
                table: "HealthPlansAggSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoConvenio_ConvenioId",
                table: "PlanoConvenio",
                column: "ConvenioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanoConvenio_TipoPlanoId",
                table: "PlanoConvenio",
                column: "TipoPlanoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConvenioHorasEspeciais");

            migrationBuilder.DropTable(
                name: "HealthPlansAggSettings");

            migrationBuilder.DropTable(
                name: "PlanoConvenio");

            migrationBuilder.DropTable(
                name: "TipoPlano");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "CodigoReferencia",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "Logomarca",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "PadronizarQuantidadeDigitos",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "QuantidadeDigitos",
                table: "Convenio");

            migrationBuilder.DropColumn(
                name: "RegistroANS",
                table: "Convenio");
        }
    }
}
