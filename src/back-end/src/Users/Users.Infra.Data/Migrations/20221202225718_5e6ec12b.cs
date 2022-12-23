using System;
using System.Collections.Generic;
using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SES.Users.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _5e6ec12b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "text", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
            //        ExternalId = table.Column<string>(type: "text", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
            //        EventsHistory = table.Column<List<EventsHistory>>(type: "jsonb", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AspNetUsers");
        }
    }
}
