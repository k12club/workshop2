using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class EmPloyeeAndBoardSeederScheema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Board",
                columns: new[] { "Id", "CodeEmployee", "Create_At", "FirstName", "LastName" },
                values: new object[] { 1L, "12601400", new DateTime(2020, 8, 14, 14, 1, 24, 100, DateTimeKind.Local).AddTicks(7074), "", null });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BoardId", "CodeEmployee", "Create_At", "FirstName", "LastName" },
                values: new object[] { 1L, 1L, "555555555", new DateTime(2020, 8, 14, 14, 1, 24, 104, DateTimeKind.Local).AddTicks(7639), "Jeerawut", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Board",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
