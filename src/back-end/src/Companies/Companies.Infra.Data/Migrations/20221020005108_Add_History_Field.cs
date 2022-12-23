using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Add_History_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "GrupoEmpresaEndereco",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "GrupoEmpresaContacts",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "GrupoEmpresaConfiguracao",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "GrupoEmpresa",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "EmpresaEndereco",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "EmpresaContacts",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "EmpresaConfiguracao",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "Empresa",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<EventsHistory>>(
                name: "EventsHistory",
                table: "CompaniesAggSettings",
                type: "jsonb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "GrupoEmpresaEndereco");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "GrupoEmpresaContacts");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "GrupoEmpresaConfiguracao");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "GrupoEmpresa");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "EmpresaEndereco");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "EmpresaContacts");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "EmpresaConfiguracao");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "EventsHistory",
                table: "CompaniesAggSettings");
        }
    }
}
