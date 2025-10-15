using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DataItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthenticationMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndpointURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentListID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMutationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalManagement = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DataItems_DocumentLists_DocumentListID",
                        column: x => x.DocumentListID,
                        principalTable: "DocumentLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentListID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentLists_DocumentListID",
                        column: x => x.DocumentListID,
                        principalTable: "DocumentLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataItems_DocumentListID",
                table: "DataItems",
                column: "DocumentListID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentListID",
                table: "Documents",
                column: "DocumentListID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataItems");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentLists");
        }
    }
}
