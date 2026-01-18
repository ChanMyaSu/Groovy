using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class Recommendation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(6656), new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(6693), new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe097fc1-0f21-4a55-af95-44bb8f4492cc", "AQAAAAIAAYagAAAAEPP1MigPi3xwW04hd92iM9EPaRSx3udp24SGACCSaKKUwdKl+VrrSYHQQ6o0i6jaTA==", "0fccaaeb-2a72-4d07-94ca-3f803d1c08cf" });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(7342), new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(7352), new DateTime(2026, 1, 18, 23, 20, 49, 105, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7676), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7689), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7700), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7709), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7719), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7729), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7739), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8060), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8071), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8093), new DateTime(2026, 1, 18, 15, 20, 49, 105, DateTimeKind.Utc).AddTicks(8094) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
