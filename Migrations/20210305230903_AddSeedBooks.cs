using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTracker.Migrations
{
    public partial class AddSeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "author", "isbn", "publication_date", "publisher", "title" },
                values: new object[,]
                {
                    { 1, "Mark Twain", "0142437174", new DateTime(1884, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Classics", "The Adventures of Huckleberry Finn" },
                    { 2, "Harper Lee", "0123456789", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harper Perennial Modern Classics", "To Kill a Mockingbird" },
                    { 3, "Charles Petzold", "9781572319950", new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft Press", "Programming Windows" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
