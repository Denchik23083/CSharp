using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.Db.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookPrices_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "PagesCount", "PublishDate", "Title" },
                values: new object[] { 1, "Джоан Роулинг", 500, new DateTime(1988, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Орден Феникса" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "PagesCount", "PublishDate", "Title" },
                values: new object[] { 2, "Джоан Роулинг", 600, new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Кубок Огня" });

            migrationBuilder.InsertData(
                table: "BookPrices",
                columns: new[] { "Id", "BookId", "Price" },
                values: new object[] { 1, 1, 300m });

            migrationBuilder.InsertData(
                table: "BookPrices",
                columns: new[] { "Id", "BookId", "Price" },
                values: new object[] { 2, 2, 350m });

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookPrices");

            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
