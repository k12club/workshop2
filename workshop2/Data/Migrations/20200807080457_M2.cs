using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "X1",
                table: "DocumentFile");

            migrationBuilder.DropColumn(
                name: "Y1",
                table: "DocumentFile");

            migrationBuilder.AddColumn<long>(
                name: "DocumentFilePositionSignatureId",
                table: "DocumentFile",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DocumentStatusId",
                table: "Document",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "Document",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SecretId",
                table: "Document",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CodeEmployee = table.Column<string>(nullable: true),
                    Create_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFilePositionSignature",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X1 = table.Column<double>(nullable: false),
                    Y1 = table.Column<double>(nullable: false),
                    SignatureToId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFilePositionSignature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentStatus",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Secret",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secret", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CodeEmployee = table.Column<string>(nullable: true),
                    BoardId = table.Column<long>(nullable: false),
                    Create_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DocumentStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "ปกติ" },
                    { 2L, "ด่วน" },
                    { 3L, "ด่วนมาก" },
                    { 4L, "ด่วนที่สุด" }
                });

            migrationBuilder.InsertData(
                table: "Secret",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "ปกติ" },
                    { 2L, "ลับ" },
                    { 3L, "ลับมาก" },
                    { 4L, "ลับที่สุด" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFile_DocumentFilePositionSignatureId",
                table: "DocumentFile",
                column: "DocumentFilePositionSignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentStatusId",
                table: "Document",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_EmployeeId",
                table: "Document",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_SecretId",
                table: "Document",
                column: "SecretId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BoardId",
                table: "Employee",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employee_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentStatus_DocumentStatusId",
                table: "Document",
                column: "DocumentStatusId",
                principalTable: "DocumentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Employee_EmployeeId",
                table: "Document",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Secret_SecretId",
                table: "Document",
                column: "SecretId",
                principalTable: "Secret",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile",
                column: "DocumentFilePositionSignatureId",
                principalTable: "DocumentFilePositionSignature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employee_EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentStatus_DocumentStatusId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Employee_EmployeeId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Secret_SecretId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentFile_DocumentFilePositionSignature_DocumentFilePositionSignatureId",
                table: "DocumentFile");

            migrationBuilder.DropTable(
                name: "DocumentFilePositionSignature");

            migrationBuilder.DropTable(
                name: "DocumentStatus");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Secret");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropIndex(
                name: "IX_DocumentFile_DocumentFilePositionSignatureId",
                table: "DocumentFile");

            migrationBuilder.DropIndex(
                name: "IX_Document_DocumentStatusId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_EmployeeId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_SecretId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DocumentFilePositionSignatureId",
                table: "DocumentFile");

            migrationBuilder.DropColumn(
                name: "DocumentStatusId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "SecretId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<double>(
                name: "X1",
                table: "DocumentFile",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Y1",
                table: "DocumentFile",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
