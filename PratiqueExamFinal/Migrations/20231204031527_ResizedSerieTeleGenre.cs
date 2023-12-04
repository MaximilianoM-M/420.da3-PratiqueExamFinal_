using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PratiqueExamFinal.Migrations
{
    /// <inheritdoc />
    public partial class ResizedSerieTeleGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "SerieTeles",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "SerieTeles",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
