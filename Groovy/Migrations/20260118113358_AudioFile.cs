using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class AudioFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(5496), new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(5533), new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4abedd4b-e6b0-48a3-af56-1889c3e0dac8", "AQAAAAIAAYagAAAAELEVC0pRHATSCaM1en0IMaccKXP8aD/BkfM/YBdgqBhVdnroiuvJORm1GMtMrAHaaA==", "3231bcb2-daec-48e2-b994-74249d99d96e" });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(6171), new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(6181), new DateTime(2026, 1, 18, 19, 33, 55, 126, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6512), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6524), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6534), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7077), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7093), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7102), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7118), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7126), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7134), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7156), new DateTime(2026, 1, 18, 11, 33, 55, 126, DateTimeKind.Utc).AddTicks(7157) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3151), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3282), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3294), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3303), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3312), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3322), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3331), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3340), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3349), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 1, 18, 10, 40, 32, 508, DateTimeKind.Utc).AddTicks(3375) });
        }
    }
}
