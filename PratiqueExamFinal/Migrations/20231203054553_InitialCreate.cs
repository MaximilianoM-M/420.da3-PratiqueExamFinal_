using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PratiqueExamFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "Acteurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomActeur = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Acteurs", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "SerieTeles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomSerieTele = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_SerieTeles", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "SerieTeleActeur",
                columns: table => new
                {
                    ActeurId = table.Column<int>(type: "int", nullable: false),
                    SerieTeleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_SerieTeleActeur", x => new { x.ActeurId, x.SerieTeleId });
                    _ = table.ForeignKey(
                        name: "FK_SerieTeleActeur_Acteurs_ActeurId",
                        column: x => x.ActeurId,
                        principalTable: "Acteurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_SerieTeleActeur_SerieTeles_SerieTeleId",
                        column: x => x.SerieTeleId,
                        principalTable: "SerieTeles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_SerieTeleActeur_SerieTeleId",
                table: "SerieTeleActeur",
                column: "SerieTeleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "SerieTeleActeur");

            _ = migrationBuilder.DropTable(
                name: "Acteurs");

            _ = migrationBuilder.DropTable(
                name: "SerieTeles");
        }
    }
}
