using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Groovy.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 2, 20, 32, 446, DateTimeKind.Local).AddTicks(9793), new DateTime(2026, 1, 16, 2, 20, 32, 446, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 2, 20, 32, 446, DateTimeKind.Local).AddTicks(9818), new DateTime(2026, 1, 16, 2, 20, 32, 446, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 16, 2, 20, 32, 447, DateTimeKind.Local).AddTicks(378), new DateTime(2026, 1, 16, 2, 20, 32, 447, DateTimeKind.Local).AddTicks(380), "Pop", "System" },
                    { 2, "System", new DateTime(2026, 1, 16, 2, 20, 32, 447, DateTimeKind.Local).AddTicks(385), new DateTime(2026, 1, 16, 2, 20, 32, 447, DateTimeKind.Local).AddTicks(387), "Rock", "System" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Bpm", "CreatedBy", "DateCreated", "DateUpdated", "DurationSec", "Energy", "MoodTag", "ReleaseDate", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 128, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(653), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(654), 245, 70, "chill", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midnight Dreams", "System" },
                    { 2, 115, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(663), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(665), 198, 85, "happy", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Vibes", "System" },
                    { 3, 140, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(672), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(673), 312, 95, "energetic", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Matter", "System" },
                    { 4, 90, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(680), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(681), 267, 40, "relaxed", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee Shop Jazz", "System" },
                    { 5, 132, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(688), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(689), 223, 88, "energetic", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neon Lights", "System" },
                    { 6, 105, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(695), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(696), 189, 55, "chill", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acoustic Sessions", "System" },
                    { 7, 145, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(703), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(705), 298, 92, "energetic", new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunder Road", "System" },
                    { 8, 75, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(711), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(712), 334, 30, "relaxed", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ocean Waves", "System" },
                    { 9, 95, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(718), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(719), 210, 78, "chill", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Lights", "System" },
                    { 10, 110, "System", new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(726), new DateTime(2026, 1, 15, 18, 20, 32, 447, DateTimeKind.Utc).AddTicks(727), 176, 65, "happy", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning Glory", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2739), new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2873), new DateTime(2026, 1, 13, 11, 19, 7, 191, DateTimeKind.Local).AddTicks(2875) });
        }
    }
}
