using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2739), new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2758), "Michael Jackson", "System" },
                    { 2, "System", new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2873), new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2875), "Madonna", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
