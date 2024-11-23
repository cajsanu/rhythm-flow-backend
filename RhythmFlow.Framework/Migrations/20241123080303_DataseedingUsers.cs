using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class DataseedingUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("466eb6ca-2b4d-479a-abbe-7c822c051241"), "securePass456", "michael.johnson@example.com" },
                    { new Guid("5ffb049f-aa63-4abd-a2f8-a3c3945d7758"), "passHash321", "chris.brown@example.com" },
                    { new Guid("62f340d0-f772-4bb0-82a2-93eac5ca33e0"), "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("6734d3c8-bfa5-451d-bd6d-9e82518d98ce"), "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("707f03f8-dfae-4f52-9562-5414f65149fb"), "hashPass753", "matthew.anderson@example.com" },
                    { new Guid("71a23542-7d7b-4444-a99d-c7fd7d1f0467"), "encryptedPass654", "sophia.wilson@example.com" },
                    { new Guid("8b3489c4-1264-43e9-81dc-990404f64e5b"), "hashedPass987", "daniel.martinez@example.com" },
                    { new Guid("94c99dc2-58cd-4b8c-a18a-926db8861ddb"), "passwordHash123", "jane.smith@example.com" },
                    { new Guid("caa90763-63ef-47eb-86ba-24ceddc5038d"), "passwordHash", "john.doe@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("466eb6ca-2b4d-479a-abbe-7c822c051241"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5ffb049f-aa63-4abd-a2f8-a3c3945d7758"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("62f340d0-f772-4bb0-82a2-93eac5ca33e0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6734d3c8-bfa5-451d-bd6d-9e82518d98ce"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("707f03f8-dfae-4f52-9562-5414f65149fb"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("71a23542-7d7b-4444-a99d-c7fd7d1f0467"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8b3489c4-1264-43e9-81dc-990404f64e5b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("94c99dc2-58cd-4b8c-a18a-926db8861ddb"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("caa90763-63ef-47eb-86ba-24ceddc5038d"));
        }
    }
}
