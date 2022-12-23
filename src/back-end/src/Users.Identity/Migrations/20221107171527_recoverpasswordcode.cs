using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SES.Users.Identity.Migrations
{
    public partial class recoverpasswordcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecoverPasswordCode",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecoverPasswordCodeDate",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecoverPasswordCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RecoverPasswordCodeDate",
                table: "AspNetUsers");
        }
    }
}
