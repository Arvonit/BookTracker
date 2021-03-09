using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BookTracker.Migrations
{
    public partial class AddBookshelves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookshelf_id",
                table: "books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "bookshelves",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bookshelves", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "bookshelves",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Want to Read" },
                    { 2, "Currently Reading" },
                    { 3, "Read" }
                });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1,
                column: "bookshelf_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2,
                column: "bookshelf_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3,
                column: "bookshelf_id",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "ix_books_bookshelf_id",
                table: "books",
                column: "bookshelf_id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_bookshelves_bookshelf_id",
                table: "books",
                column: "bookshelf_id",
                principalTable: "bookshelves",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_books_bookshelves_bookshelf_id",
                table: "books");

            migrationBuilder.DropTable(
                name: "bookshelves");

            migrationBuilder.DropIndex(
                name: "ix_books_bookshelf_id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "bookshelf_id",
                table: "books");
        }
    }
}
