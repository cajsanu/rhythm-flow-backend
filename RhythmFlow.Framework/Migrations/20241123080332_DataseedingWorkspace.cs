using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class DataseedingWorkspace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("1dc3ca67-c09c-45be-9743-8270b5c8aa10"), "hashedPass987", "daniel.martinez@example.com" },
                    { new Guid("237f94e0-186d-4ccc-b701-f6f453b14afc"), "passwordHash123", "jane.smith@example.com" },
                    { new Guid("2e7c1689-8604-43fb-9f88-2f6d6bb5a5e9"), "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("44f7479e-7e1f-4e61-ac1f-de49784cae79"), "hashPass753", "matthew.anderson@example.com" },
                    { new Guid("4f1a3aa5-db5c-4a1d-8c18-714424669b3b"), "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("5e246de2-3cb0-43a4-b309-ec90e72a5da3"), "passHash321", "chris.brown@example.com" },
                    { new Guid("7c3bb159-279c-44ee-ace3-43f7c643716a"), "passwordHash", "john.doe@example.com" },
                    { new Guid("fcff22d1-10df-44a4-b601-df13186b237a"), "securePass456", "michael.johnson@example.com" },
                    { new Guid("fd10262d-8061-43a2-84d0-3c2c256c558a"), "encryptedPass654", "sophia.wilson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("3cbe7c45-cdcd-40d8-82dc-b9859607c170"), "Marketing", new Guid("7c3bb159-279c-44ee-ace3-43f7c643716a") },
                    { new Guid("7444baee-db2b-4110-b1be-ebe4d7fbf890"), "HR", new Guid("5e246de2-3cb0-43a4-b309-ec90e72a5da3") },
                    { new Guid("829b6f8b-3ad9-40f6-a41b-12027e3f2268"), "Sales", new Guid("4f1a3aa5-db5c-4a1d-8c18-714424669b3b") },
                    { new Guid("b02fc408-2660-49ec-936d-4a45cd7d0ecf"), "Design", new Guid("fcff22d1-10df-44a4-b601-df13186b237a") },
                    { new Guid("b2f1e89d-d76d-4f38-88c4-469008ec6580"), "Development", new Guid("237f94e0-186d-4ccc-b701-f6f453b14afc") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1dc3ca67-c09c-45be-9743-8270b5c8aa10"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("237f94e0-186d-4ccc-b701-f6f453b14afc"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("2e7c1689-8604-43fb-9f88-2f6d6bb5a5e9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("44f7479e-7e1f-4e61-ac1f-de49784cae79"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4f1a3aa5-db5c-4a1d-8c18-714424669b3b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5e246de2-3cb0-43a4-b309-ec90e72a5da3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("7c3bb159-279c-44ee-ace3-43f7c643716a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fcff22d1-10df-44a4-b601-df13186b237a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fd10262d-8061-43a2-84d0-3c2c256c558a"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("3cbe7c45-cdcd-40d8-82dc-b9859607c170"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("7444baee-db2b-4110-b1be-ebe4d7fbf890"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("829b6f8b-3ad9-40f6-a41b-12027e3f2268"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("b02fc408-2660-49ec-936d-4a45cd7d0ecf"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("b2f1e89d-d76d-4f38-88c4-469008ec6580"));

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
    }
}
