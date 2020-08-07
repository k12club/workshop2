using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Create_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFileStatus",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFileStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    X1 = table.Column<double>(nullable: false),
                    Y1 = table.Column<double>(nullable: false),
                    DocumentFileStatusId = table.Column<long>(nullable: false),
                    DocumentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentFile_DocumentFileStatus_DocumentFileStatusId",
                        column: x => x.DocumentFileStatusId,
                        principalTable: "DocumentFileStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentFile_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DocumentFileStatus",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "general" });

            migrationBuilder.InsertData(
                table: "DocumentFileStatus",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2L, "signature" });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFile_DocumentFileStatusId",
                table: "DocumentFile",
                column: "DocumentFileStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFile_DocumentId",
                table: "DocumentFile",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentFile");

            migrationBuilder.DropTable(
                name: "DocumentFileStatus");

            migrationBuilder.DropTable(
                name: "Document");
        }
    }
}
