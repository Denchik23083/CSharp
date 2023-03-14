﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApi.Db.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "First Category" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Second Category" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "PagesCount", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Джоан Роулинг", 1, 500, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и философский камень" },
                    { 3, "Джоан Роулинг", 1, 600, new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и узник Азкабана" },
                    { 2, "Джоан Роулинг", 2, 450, new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Тайная комната" },
                    { 4, "Джоан Роулинг", 2, 700, new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гарри Поттер и Кубок огня" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
