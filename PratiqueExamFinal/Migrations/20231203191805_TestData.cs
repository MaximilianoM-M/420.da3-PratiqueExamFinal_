﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PratiqueExamFinal.Migrations
{
    /// <inheritdoc />
    public partial class TestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.InsertData(
                table: "Acteurs",
                columns: new[] { "Id", "Age", "NomActeur" },
                values: new object[,]
                {
                    { 1, "48", "Pedro Pascal" },
                    { 2, "30", "Zach Tyler" },
                    { 3, "65", "Giancarlo Esposito" }
                });

            _ = migrationBuilder.InsertData(
                table: "SerieTeles",
                columns: new[] { "Id", "Genre", "NomSerieTele" },
                values: new object[,]
                {
                    { 1, "Science-Fiction", "Mandalorian" },
                    { 2, "Adventure", "Avatar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DeleteData(
                table: "Acteurs",
                keyColumn: "Id",
                keyValue: 1);

            _ = migrationBuilder.DeleteData(
                table: "Acteurs",
                keyColumn: "Id",
                keyValue: 2);

            _ = migrationBuilder.DeleteData(
                table: "Acteurs",
                keyColumn: "Id",
                keyValue: 3);

            _ = migrationBuilder.DeleteData(
                table: "SerieTeles",
                keyColumn: "Id",
                keyValue: 1);

            _ = migrationBuilder.DeleteData(
                table: "SerieTeles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
