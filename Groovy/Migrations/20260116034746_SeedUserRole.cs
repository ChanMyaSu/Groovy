using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2159), new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2184), new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1abdffb2-337b-4e1b-a87d-efe9d4bf55e4", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI7QRN99gWBwS9r2jq9GT9p7T8/xLFpqdWFAMOyF7XDhqcuLD6OaajRdOZxPmL+ohQ==", null, false, "24f0e0a0-5514-47ab-974a-2811a1e9e4a7", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2635), new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2641), new DateTime(2026, 1, 16, 11, 47, 43, 825, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2840), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2850), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2858), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2867), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2875), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2882), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2890), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2897), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2993), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(3002), new DateTime(2026, 1, 16, 3, 47, 43, 825, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(7845), new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(7874), new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(8337), new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(8344), new DateTime(2026, 1, 16, 11, 11, 41, 800, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8577), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8590), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8725), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8736), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8747), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8756), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8770), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8779), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8787), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8795), new DateTime(2026, 1, 16, 3, 11, 41, 800, DateTimeKind.Utc).AddTicks(8797) });
        }
    }
}
