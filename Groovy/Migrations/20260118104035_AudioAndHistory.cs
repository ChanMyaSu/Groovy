using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class AudioAndHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AudioFilePath",
                table: "Song",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2058), new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2095), new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7474434b-3bf4-41d2-b54b-49750f27f5d3", "AQAAAAIAAYagAAAAEElduTiZZhH7cnHyDuJxKSJQN1x0/x/KTbj26p6yRXDpurtLSekJCY1W+vLENC4SDA==", "8706574f-c4c2-4b09-a1ea-e301360922e1" });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2817), new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2826), new DateTime(2026, 1, 18, 18, 40, 32, 508, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3151), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3282), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3294), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3303), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3312), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3322), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3331), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3340), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3349), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AudioFilePath", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3375) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioFilePath",
                table: "Song");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1abdffb2-337b-4e1b-a87d-efe9d4bf55e4", "AQAAAAIAAYagAAAAEI7QRN99gWBwS9r2jq9GT9p7T8/xLFpqdWFAMOyF7XDhqcuLD6OaajRdOZxPmL+ohQ==", "24f0e0a0-5514-47ab-974a-2811a1e9e4a7" });

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
        }
    }
}
