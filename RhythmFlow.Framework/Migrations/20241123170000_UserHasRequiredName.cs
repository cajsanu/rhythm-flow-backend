using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class UserHasRequiredName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "end_date", "name", "start_date", "status", "workspace_id" },
                values: new object[,]
                {
                    { new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"), "Develop AI Assistant", new DateOnly(2025, 1, 22), "Beta", new DateOnly(2024, 11, 28), "NotStarted", new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9") },
                    { new Guid("266649a6-03b6-46c0-b039-c324229ba5e7"), "Implement Cloud Migration", new DateOnly(2025, 3, 23), "Epsilon", new DateOnly(2024, 11, 24), "Cancelled", new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd") },
                    { new Guid("2a4f7751-6e2f-4848-9939-1c37a3be3ea7"), "Revamp Website Design", new DateOnly(2025, 1, 7), "Gamma", new DateOnly(2024, 11, 26), "InProgress", new Guid("2af8941b-ba86-4fff-9063-ad77493ba820") },
                    { new Guid("92f670db-85d3-4b9a-bc71-596cc705cbd6"), "Launch Mobile App", new DateOnly(2025, 2, 21), "Delta", new DateOnly(2024, 11, 30), "InProgress", new Guid("8e283f09-2057-4a72-ba7a-bef88a4a125f") },
                    { new Guid("a67a2929-fc12-4dd4-8efc-8ccc59949091"), "Optimize Data Pipeline", new DateOnly(2025, 2, 11), "Zeta", new DateOnly(2024, 12, 3), "InProgress", new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd") },
                    { new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"), "Conquer the Galaxy", new DateOnly(2025, 1, 12), "Alpha", new DateOnly(2024, 11, 25), "InProgress", new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("2af1f7f8-f480-4c1e-afe7-42d22f90ba2e"), new DateOnly(2024, 11, 28), "Fix issue with incorrect data rendering", "High", new Guid("a67a2929-fc12-4dd4-8efc-8ccc59949091"), "InProgress", "Bug in Report Generation", 1 },
                    { new Guid("424d7a17-b1b0-4997-8540-99feec60ccd8"), new DateOnly(2024, 12, 7), "Create wireframe for new landing page", "Medium", new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("44c8d122-5216-4e8e-b723-0e52b8fcd5ad"), new DateOnly(2024, 12, 23), "Review and update policy document", "Low", new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"), "NotStarted", "Update Privacy Policy", 2 },
                    { new Guid("48909356-7bc0-481b-a9f5-4bc62dadfcac"), new DateOnly(2024, 11, 26), "Resolve authentication error", "High", new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("5af13a4f-7c92-4f01-ad25-30130e97cdd9"), new DateOnly(2024, 12, 14), "Implement dark mode toggle for Users", "High", new Guid("266649a6-03b6-46c0-b039-c324229ba5e7"), "Cancelled", "Add Dark Mode", 0 },
                    { new Guid("96a78659-bdbd-4c68-9cf7-327a950a5bde"), new DateOnly(2024, 11, 30), "using Postgres", "High", new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"), "InProgress", "Create Database", 0 },
                    { new Guid("b0daa214-79c7-4c85-8be8-b91df3ca3ee1"), new DateOnly(2024, 11, 30), "Plan onboarding session for new hires", "Medium", new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("fe8ca3b0-416b-4ebc-8905-e264df89d71e"), new DateOnly(2024, 12, 3), "Enhance performance of existing API calls", "High", new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"), "InProgress", "Optimize API", 1 }
                });

            migrationBuilder.InsertData(
                table: "user_workspaces",
                columns: new[] { "user_id", "workspace_id", "role" },
                values: new object[,]
                {
                    { new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"), 1 },
                    { new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"), 1 },
                    { new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"), 1 },
                    { new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"), 2 },
                    { new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"), 2 },
                    { new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"), 1 },
                    { new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"), new Guid("2af8941b-ba86-4fff-9063-ad77493ba820"), 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "first_name", "last_name", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"), "Jane", "Smith", "passwordHash123", "jane.smith@example.com" },
                    { new Guid("3f30dd69-54e4-4331-839d-088044a173ba"), "Olivia", "Garcia", "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c"), "Chris", "Brown", "passHash321", "chris.brown@example.com" },
                    { new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"), "Emily", "Davis", "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"), "Matthew", "Anderson", "hashPass753", "matthew.anderson@example.com" },
                    { new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"), "Sophia", "Wilson", "encryptedPass654", "sophia.wilson@example.com" },
                    { new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"), "Daniel", "Martinez", "hashedPass987", "daniel.martinez@example.com" },
                    { new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"), "John", "Doe", "passwordHash", "john.doe@example.com" },
                    { new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"), "Michael", "Johnson", "securePass456", "michael.johnson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("2af8941b-ba86-4fff-9063-ad77493ba820"), "Design", new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6") },
                    { new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd"), "HR", new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c") },
                    { new Guid("8e283f09-2057-4a72-ba7a-bef88a4a125f"), "Sales", new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c") },
                    { new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"), "Development", new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5") },
                    { new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"), "Marketing", new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("266649a6-03b6-46c0-b039-c324229ba5e7"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("2a4f7751-6e2f-4848-9939-1c37a3be3ea7"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("92f670db-85d3-4b9a-bc71-596cc705cbd6"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("a67a2929-fc12-4dd4-8efc-8ccc59949091"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("2af1f7f8-f480-4c1e-afe7-42d22f90ba2e"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("424d7a17-b1b0-4997-8540-99feec60ccd8"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("44c8d122-5216-4e8e-b723-0e52b8fcd5ad"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("48909356-7bc0-481b-a9f5-4bc62dadfcac"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("5af13a4f-7c92-4f01-ad25-30130e97cdd9"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("96a78659-bdbd-4c68-9cf7-327a950a5bde"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("b0daa214-79c7-4c85-8be8-b91df3ca3ee1"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("fe8ca3b0-416b-4ebc-8905-e264df89d71e"));

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"), new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"), new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"), new Guid("2af8941b-ba86-4fff-9063-ad77493ba820") });

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3f30dd69-54e4-4331-839d-088044a173ba"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("2af8941b-ba86-4fff-9063-ad77493ba820"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("8e283f09-2057-4a72-ba7a-bef88a4a125f"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"));

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "users");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "users");

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
    }
}
