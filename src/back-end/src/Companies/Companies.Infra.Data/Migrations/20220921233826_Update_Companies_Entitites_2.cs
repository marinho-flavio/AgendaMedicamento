using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    public partial class Update_Companies_Entitites_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "SetorProprio",
                table: "GrupoEmpresaConfiguracao",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<ImageFileInfo>(
                name: "Logo",
                table: "GrupoEmpresaConfiguracao",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(ImageFileInfo),
                oldType: "jsonb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "GrupoEmpresaConfiguracao",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SetorProprio",
                table: "GrupoEmpresaConfiguracao",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<ImageFileInfo>(
                name: "Logo",
                table: "GrupoEmpresaConfiguracao",
                type: "jsonb",
                nullable: false,
                oldClrType: typeof(ImageFileInfo),
                oldType: "jsonb",
                oldNullable: true);
        }
    }
}
