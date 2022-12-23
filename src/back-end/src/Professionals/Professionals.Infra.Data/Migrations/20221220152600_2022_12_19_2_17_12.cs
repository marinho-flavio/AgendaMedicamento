using System;
using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Professionals.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bravo.Professionals.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2022121921712 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfissionalConfiguracaoId",
                table: "Profissional",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProfissionalConfiguracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Logo = table.Column<ImageFileInfo>(type: "jsonb", nullable: true),
                    SetorProprio = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionalConfiguracao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_ProfissionalConfiguracaoId",
                table: "Profissional",
                column: "ProfissionalConfiguracaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profissional_ProfissionalConfiguracao_ProfissionalConfigura~",
                table: "Profissional",
                column: "ProfissionalConfiguracaoId",
                principalTable: "ProfissionalConfiguracao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profissional_ProfissionalConfiguracao_ProfissionalConfigura~",
                table: "Profissional");

            migrationBuilder.DropTable(
                name: "ProfissionalConfiguracao");

            migrationBuilder.DropIndex(
                name: "IX_Profissional_ProfissionalConfiguracaoId",
                table: "Profissional");

            migrationBuilder.DropColumn(
                name: "ProfissionalConfiguracaoId",
                table: "Profissional");
        }
    }
}
