using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class UserRequiredName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("40e02149-c456-4a6f-a96a-e3861aeb316f"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("8653c883-55ce-41f5-83bc-a32f1ed433b8"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("a13c4bdf-53df-4f75-835f-243be4418d2e"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("d9d6a494-b01d-48fb-876f-e1cc0247ef08"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("0e98de84-b57c-47b4-9adc-2cd5777a084c"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("16fabca7-dcae-480c-b825-b67622edee86"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("17aada48-fc6f-4e90-8fcf-706c0267e1c6"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("4ebe4156-c4f2-468a-bb46-f2e872f93f63"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("6922f991-4523-481b-8d7f-3d9e90df6762"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("94aa18ab-8280-4ac5-983a-4596b1f1bf39"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("a7cb3a68-db21-474f-859c-0c1d0210eb8b"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("b64b10e6-cb1d-45f3-a8e0-ce46dc3c59cd"));

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"), new Guid("8d78d550-1748-457f-9875-945203f6f966") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"), new Guid("8d78d550-1748-457f-9875-945203f6f966") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"), new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"), new Guid("8d78d550-1748-457f-9875-945203f6f966") });

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("86836b55-c5b4-4a8e-b6c1-d8c797cb7a28"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("8d78d550-1748-457f-9875-945203f6f966"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("a72a8d11-39b3-4faf-9827-73a9d1275519"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("c994312e-ccd5-4539-849d-85f7c839a642"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"));

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "end_date", "name", "start_date", "status", "workspace_id" },
                values: new object[,]
                {
                    { new Guid("088b7b9c-9d4b-4223-acca-4aca8c70b56a"), "Develop AI Assistant", new DateOnly(2025, 1, 22), "Beta", new DateOnly(2024, 11, 28), "NotStarted", new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b") },
                    { new Guid("2450d826-d0c6-44d4-8b58-4de409f970f8"), "Conquer the Galaxy", new DateOnly(2025, 1, 12), "Alpha", new DateOnly(2024, 11, 25), "InProgress", new Guid("54e9be49-a79b-4571-b553-d99c95be49c6") },
                    { new Guid("24ef3292-7217-4ddb-9946-28e64e9b224c"), "Launch Mobile App", new DateOnly(2025, 2, 21), "Delta", new DateOnly(2024, 11, 30), "InProgress", new Guid("6f89a60a-2b90-46e0-8a12-b803d5de3253") },
                    { new Guid("47da68e6-19e1-4a2c-8624-7d48b8b243b7"), "Implement Cloud Migration", new DateOnly(2025, 3, 23), "Epsilon", new DateOnly(2024, 11, 24), "Cancelled", new Guid("9ba7f963-f652-4de4-a6b1-a2b7544efc83") },
                    { new Guid("a9ad74a2-2122-433f-9484-8039ad7c8906"), "Optimize Data Pipeline", new DateOnly(2025, 2, 11), "Zeta", new DateOnly(2024, 12, 3), "InProgress", new Guid("9ba7f963-f652-4de4-a6b1-a2b7544efc83") },
                    { new Guid("c2c844ff-3afe-4e7d-97af-b0d6c386b81a"), "Revamp Website Design", new DateOnly(2025, 1, 7), "Gamma", new DateOnly(2024, 11, 26), "InProgress", new Guid("08e850d1-386d-4a80-941e-55c70265f689") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("06adb4b3-2ba0-4c5a-99a7-be40ea9f8fb5"), new DateOnly(2024, 12, 3), "Enhance performance of existing API calls", "High", new Guid("088b7b9c-9d4b-4223-acca-4aca8c70b56a"), "InProgress", "Optimize API", 1 },
                    { new Guid("08e083f0-5ee0-49a5-8501-6bf31f4d832a"), new DateOnly(2024, 12, 14), "Implement dark mode toggle for Users", "High", new Guid("47da68e6-19e1-4a2c-8624-7d48b8b243b7"), "Cancelled", "Add Dark Mode", 0 },
                    { new Guid("3639a560-ff0c-425d-aff0-65bb6d190d2f"), new DateOnly(2024, 12, 23), "Review and update policy document", "Low", new Guid("088b7b9c-9d4b-4223-acca-4aca8c70b56a"), "NotStarted", "Update Privacy Policy", 2 },
                    { new Guid("48565efc-68ea-4c78-88b5-b30f99caa645"), new DateOnly(2024, 11, 28), "Fix issue with incorrect data rendering", "High", new Guid("a9ad74a2-2122-433f-9484-8039ad7c8906"), "InProgress", "Bug in Report Generation", 1 },
                    { new Guid("4b7d9213-44fc-472b-babb-f49bda47acff"), new DateOnly(2024, 11, 26), "Resolve authentication error", "High", new Guid("2450d826-d0c6-44d4-8b58-4de409f970f8"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("626f5da6-644c-419e-bab0-da02fc62ae58"), new DateOnly(2024, 11, 30), "Plan onboarding session for new hires", "Medium", new Guid("088b7b9c-9d4b-4223-acca-4aca8c70b56a"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("90d9e678-da9b-4f73-a8e0-c65cd58ce3e8"), new DateOnly(2024, 12, 7), "Create wireframe for new landing page", "Medium", new Guid("2450d826-d0c6-44d4-8b58-4de409f970f8"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("cabda972-0a03-4587-9864-e71b6100b7e8"), new DateOnly(2024, 11, 30), "using Postgres", "High", new Guid("2450d826-d0c6-44d4-8b58-4de409f970f8"), "InProgress", "Create Database", 0 }
                });

            migrationBuilder.InsertData(
                table: "user_workspaces",
                columns: new[] { "user_id", "workspace_id", "role" },
                values: new object[,]
                {
                    { new Guid("3b7e8952-7643-4e8a-a254-6f5a971ebeb1"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6"), 1 },
                    { new Guid("4b681381-f5be-4ddc-8727-7fd860ce0662"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b"), 2 },
                    { new Guid("77ef7144-30be-4951-abfc-41f96b7b4733"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b"), 1 },
                    { new Guid("8c8135a1-6d25-4931-b995-0a2ebf4308ed"), new Guid("08e850d1-386d-4a80-941e-55c70265f689"), 1 },
                    { new Guid("95a101f2-b7c6-4d44-a9ab-5b70ebfd09bf"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6"), 1 },
                    { new Guid("9f554867-8460-498a-b07b-f81a34b1c548"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6"), 1 },
                    { new Guid("afd8f599-bcbe-4c3f-8091-446e8eaf2204"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b"), 2 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("3b7e8952-7643-4e8a-a254-6f5a971ebeb1"), "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("4419b211-d1f5-448c-afa0-b52c890301e9"), "passHash321", "chris.brown@example.com" },
                    { new Guid("4b681381-f5be-4ddc-8727-7fd860ce0662"), "encryptedPass654", "sophia.wilson@example.com" },
                    { new Guid("6f13b8ec-ff2d-4db4-8815-00705e41ffbf"), "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("77ef7144-30be-4951-abfc-41f96b7b4733"), "passwordHash123", "jane.smith@example.com" },
                    { new Guid("8c8135a1-6d25-4931-b995-0a2ebf4308ed"), "securePass456", "michael.johnson@example.com" },
                    { new Guid("95a101f2-b7c6-4d44-a9ab-5b70ebfd09bf"), "passwordHash", "john.doe@example.com" },
                    { new Guid("9f554867-8460-498a-b07b-f81a34b1c548"), "hashPass753", "matthew.anderson@example.com" },
                    { new Guid("afd8f599-bcbe-4c3f-8091-446e8eaf2204"), "hashedPass987", "daniel.martinez@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("08e850d1-386d-4a80-941e-55c70265f689"), "Design", new Guid("8c8135a1-6d25-4931-b995-0a2ebf4308ed") },
                    { new Guid("54e9be49-a79b-4571-b553-d99c95be49c6"), "Marketing", new Guid("95a101f2-b7c6-4d44-a9ab-5b70ebfd09bf") },
                    { new Guid("6f89a60a-2b90-46e0-8a12-b803d5de3253"), "Sales", new Guid("3b7e8952-7643-4e8a-a254-6f5a971ebeb1") },
                    { new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b"), "Development", new Guid("77ef7144-30be-4951-abfc-41f96b7b4733") },
                    { new Guid("9ba7f963-f652-4de4-a6b1-a2b7544efc83"), "HR", new Guid("4419b211-d1f5-448c-afa0-b52c890301e9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("088b7b9c-9d4b-4223-acca-4aca8c70b56a"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("2450d826-d0c6-44d4-8b58-4de409f970f8"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("24ef3292-7217-4ddb-9946-28e64e9b224c"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("47da68e6-19e1-4a2c-8624-7d48b8b243b7"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("a9ad74a2-2122-433f-9484-8039ad7c8906"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("c2c844ff-3afe-4e7d-97af-b0d6c386b81a"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("06adb4b3-2ba0-4c5a-99a7-be40ea9f8fb5"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("08e083f0-5ee0-49a5-8501-6bf31f4d832a"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("3639a560-ff0c-425d-aff0-65bb6d190d2f"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("48565efc-68ea-4c78-88b5-b30f99caa645"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("4b7d9213-44fc-472b-babb-f49bda47acff"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("626f5da6-644c-419e-bab0-da02fc62ae58"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("90d9e678-da9b-4f73-a8e0-c65cd58ce3e8"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("cabda972-0a03-4587-9864-e71b6100b7e8"));

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("3b7e8952-7643-4e8a-a254-6f5a971ebeb1"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("4b681381-f5be-4ddc-8727-7fd860ce0662"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("77ef7144-30be-4951-abfc-41f96b7b4733"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("8c8135a1-6d25-4931-b995-0a2ebf4308ed"), new Guid("08e850d1-386d-4a80-941e-55c70265f689") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("95a101f2-b7c6-4d44-a9ab-5b70ebfd09bf"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("9f554867-8460-498a-b07b-f81a34b1c548"), new Guid("54e9be49-a79b-4571-b553-d99c95be49c6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("afd8f599-bcbe-4c3f-8091-446e8eaf2204"), new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b") });

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3b7e8952-7643-4e8a-a254-6f5a971ebeb1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4419b211-d1f5-448c-afa0-b52c890301e9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4b681381-f5be-4ddc-8727-7fd860ce0662"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6f13b8ec-ff2d-4db4-8815-00705e41ffbf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("77ef7144-30be-4951-abfc-41f96b7b4733"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8c8135a1-6d25-4931-b995-0a2ebf4308ed"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("95a101f2-b7c6-4d44-a9ab-5b70ebfd09bf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9f554867-8460-498a-b07b-f81a34b1c548"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("afd8f599-bcbe-4c3f-8091-446e8eaf2204"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("08e850d1-386d-4a80-941e-55c70265f689"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("54e9be49-a79b-4571-b553-d99c95be49c6"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("6f89a60a-2b90-46e0-8a12-b803d5de3253"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("9b021d86-f6db-45cf-a099-d610c0a2489b"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("9ba7f963-f652-4de4-a6b1-a2b7544efc83"));

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "end_date", "name", "start_date", "status", "workspace_id" },
                values: new object[,]
                {
                    { new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"), "Conquer the Galaxy", new DateOnly(2025, 1, 12), "Alpha", new DateOnly(2024, 11, 25), "InProgress", new Guid("8d78d550-1748-457f-9875-945203f6f966") },
                    { new Guid("40e02149-c456-4a6f-a96a-e3861aeb316f"), "Revamp Website Design", new DateOnly(2025, 1, 7), "Gamma", new DateOnly(2024, 11, 26), "InProgress", new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef") },
                    { new Guid("8653c883-55ce-41f5-83bc-a32f1ed433b8"), "Implement Cloud Migration", new DateOnly(2025, 3, 23), "Epsilon", new DateOnly(2024, 11, 24), "Cancelled", new Guid("c994312e-ccd5-4539-849d-85f7c839a642") },
                    { new Guid("a13c4bdf-53df-4f75-835f-243be4418d2e"), "Optimize Data Pipeline", new DateOnly(2025, 2, 11), "Zeta", new DateOnly(2024, 12, 3), "InProgress", new Guid("c994312e-ccd5-4539-849d-85f7c839a642") },
                    { new Guid("d9d6a494-b01d-48fb-876f-e1cc0247ef08"), "Launch Mobile App", new DateOnly(2025, 2, 21), "Delta", new DateOnly(2024, 11, 30), "InProgress", new Guid("a72a8d11-39b3-4faf-9827-73a9d1275519") },
                    { new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"), "Develop AI Assistant", new DateOnly(2025, 1, 22), "Beta", new DateOnly(2024, 11, 28), "NotStarted", new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("0e98de84-b57c-47b4-9adc-2cd5777a084c"), new DateOnly(2024, 11, 30), "using Postgres", "High", new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"), "InProgress", "Create Database", 0 },
                    { new Guid("16fabca7-dcae-480c-b825-b67622edee86"), new DateOnly(2024, 12, 7), "Create wireframe for new landing page", "Medium", new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("17aada48-fc6f-4e90-8fcf-706c0267e1c6"), new DateOnly(2024, 11, 26), "Resolve authentication error", "High", new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("4ebe4156-c4f2-468a-bb46-f2e872f93f63"), new DateOnly(2024, 11, 28), "Fix issue with incorrect data rendering", "High", new Guid("a13c4bdf-53df-4f75-835f-243be4418d2e"), "InProgress", "Bug in Report Generation", 1 },
                    { new Guid("6922f991-4523-481b-8d7f-3d9e90df6762"), new DateOnly(2024, 12, 3), "Enhance performance of existing API calls", "High", new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"), "InProgress", "Optimize API", 1 },
                    { new Guid("94aa18ab-8280-4ac5-983a-4596b1f1bf39"), new DateOnly(2024, 12, 14), "Implement dark mode toggle for Users", "High", new Guid("8653c883-55ce-41f5-83bc-a32f1ed433b8"), "Cancelled", "Add Dark Mode", 0 },
                    { new Guid("a7cb3a68-db21-474f-859c-0c1d0210eb8b"), new DateOnly(2024, 11, 30), "Plan onboarding session for new hires", "Medium", new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("b64b10e6-cb1d-45f3-a8e0-ce46dc3c59cd"), new DateOnly(2024, 12, 23), "Review and update policy document", "Low", new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"), "NotStarted", "Update Privacy Policy", 2 }
                });

            migrationBuilder.InsertData(
                table: "user_workspaces",
                columns: new[] { "user_id", "workspace_id", "role" },
                values: new object[,]
                {
                    { new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"), new Guid("8d78d550-1748-457f-9875-945203f6f966"), 1 },
                    { new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"), new Guid("8d78d550-1748-457f-9875-945203f6f966"), 1 },
                    { new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"), 2 },
                    { new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"), 1 },
                    { new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"), new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef"), 1 },
                    { new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"), new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"), 2 },
                    { new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"), new Guid("8d78d550-1748-457f-9875-945203f6f966"), 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"), "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2"), "passHash321", "chris.brown@example.com" },
                    { new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"), "passwordHash", "john.doe@example.com" },
                    { new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"), "hashedPass987", "daniel.martinez@example.com" },
                    { new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"), "passwordHash123", "jane.smith@example.com" },
                    { new Guid("86836b55-c5b4-4a8e-b6c1-d8c797cb7a28"), "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"), "securePass456", "michael.johnson@example.com" },
                    { new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"), "encryptedPass654", "sophia.wilson@example.com" },
                    { new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"), "hashPass753", "matthew.anderson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef"), "Design", new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216") },
                    { new Guid("8d78d550-1748-457f-9875-945203f6f966"), "Marketing", new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da") },
                    { new Guid("a72a8d11-39b3-4faf-9827-73a9d1275519"), "Sales", new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15") },
                    { new Guid("c994312e-ccd5-4539-849d-85f7c839a642"), "HR", new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2") },
                    { new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"), "Development", new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d") }
                });
        }
    }
}
