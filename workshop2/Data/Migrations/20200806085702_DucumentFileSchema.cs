using Microsoft.EntityFrameworkCore.Migrations;

namespace workshop2.Data.Migrations
{
    public partial class DucumentFileSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentFile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    DocumentId = table.Column<long>(nullable: false),
                    DocumemtId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentFile_Documemt_DocumemtId",
                        column: x => x.DocumemtId,
                        principalTable: "Documemt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFile_DocumemtId",
                table: "DocumentFile",
                column: "DocumemtId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentFile");
        }
    }
}
