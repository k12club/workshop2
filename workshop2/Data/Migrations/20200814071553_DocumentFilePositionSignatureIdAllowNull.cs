using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class DocumentFilePositionSignatureIdAllowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentFilePositionSignatureId",
                table: "DocumentFile",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Board",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Create_At",
                value: new DateTime(2020, 8, 14, 14, 15, 53, 154, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Create_At",
                value: new DateTime(2020, 8, 14, 14, 15, 53, 157, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile",
                column: "DocumentFilePositionSignatureId",
                principalTable: "DocumentFilePositionSignature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentFilePositionSignatureId",
                table: "DocumentFile",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Board",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Create_At",
                value: new DateTime(2020, 8, 14, 14, 1, 24, 100, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Create_At",
                value: new DateTime(2020, 8, 14, 14, 1, 24, 104, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile",
                column: "DocumentFilePositionSignatureId",
                principalTable: "DocumentFilePositionSignature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
