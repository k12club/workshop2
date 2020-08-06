using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class DocumentAddCreate_AtSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Create_At",
                table: "Documemt",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Create_At",
                table: "Documemt");
        }
    }
}
