using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTracker.Migrations
{
    public partial class ChangePublicationYearToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "year_published",
                table: "books",
                newName: "publication_date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publication_date",
                table: "books",
                newName: "year_published");
        }
    }
}
