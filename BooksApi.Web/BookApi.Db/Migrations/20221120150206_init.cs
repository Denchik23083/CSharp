using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApi.Db.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PagesCount", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Джоан Роулинг", 500, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и философский камень" },
                    { 2, "Джоан Роулинг", 450, new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Тайная комната" },
                    { 3, "Джоан Роулинг", 600, new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и узник Азкабана" },
                    { 4, "Джоан Роулинг", 700, new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Кубок огня" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
