using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class HashSeedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "end_date", "name", "start_date", "status", "workspace_id" },
                values: new object[,]
                {
                    { new Guid("0dad8c65-ce0f-4429-8aff-977b02f7daed"), "Implement Cloud Migration", new DateOnly(2025, 3, 24), "Epsilon", new DateOnly(2024, 11, 25), "Cancelled", new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d") },
                    { new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"), "Conquer the Galaxy", new DateOnly(2025, 1, 13), "Alpha", new DateOnly(2024, 11, 26), "InProgress", new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d") },
                    { new Guid("a0b80cae-e906-4c2b-813b-9b922e633b5d"), "Optimize Data Pipeline", new DateOnly(2025, 2, 12), "Zeta", new DateOnly(2024, 12, 4), "InProgress", new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d") },
                    { new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"), "Develop AI Assistant", new DateOnly(2025, 1, 23), "Beta", new DateOnly(2024, 11, 29), "NotStarted", new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6") },
                    { new Guid("b7cd139c-f87b-417f-8a39-24732f7146c9"), "Revamp Website Design", new DateOnly(2025, 1, 8), "Gamma", new DateOnly(2024, 11, 27), "InProgress", new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d") },
                    { new Guid("e860e23e-3616-4e8d-b517-8e62e92740b6"), "Launch Mobile App", new DateOnly(2025, 2, 22), "Delta", new DateOnly(2024, 12, 1), "InProgress", new Guid("1d2128f7-fc01-44c9-b221-1079a6b5594e") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("0fbeb34e-0e33-4658-ab7e-e2e88c24ae63"), new DateOnly(2024, 12, 8), "Create wireframe for new landing page", "Medium", new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("521f0ab4-8a2e-4fed-98e7-ef1a681dbaa5"), new DateOnly(2024, 12, 1), "Plan onboarding session for new hires", "Medium", new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("5a2e061c-4bc4-4350-9e21-83326ca4abe3"), new DateOnly(2024, 12, 24), "Review and update policy document", "Low", new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"), "NotStarted", "Update Privacy Policy", 2 },
                    { new Guid("5c239a93-75f1-4dd8-a969-6d06cf78fe6a"), new DateOnly(2024, 12, 1), "using Postgres", "High", new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"), "InProgress", "Create Database", 0 },
                    { new Guid("5d11edda-9957-44c7-a32b-51b2f1a7de0a"), new DateOnly(2024, 12, 4), "Enhance performance of existing API calls", "High", new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"), "InProgress", "Optimize API", 1 },
                    { new Guid("a72df026-d893-469d-b625-5206c131bf30"), new DateOnly(2024, 11, 29), "Fix issue with incorrect data rendering", "High", new Guid("a0b80cae-e906-4c2b-813b-9b922e633b5d"), "InProgress", "Bug in Report Generation", 1 },
                    { new Guid("d92858fd-f52a-466c-aab8-c672bff78f23"), new DateOnly(2024, 11, 27), "Resolve authentication error", "High", new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("fb69de22-22fa-4117-a74b-139fcf017106"), new DateOnly(2024, 12, 15), "Implement dark mode toggle for Users", "High", new Guid("0dad8c65-ce0f-4429-8aff-977b02f7daed"), "Cancelled", "Add Dark Mode", 0 }
                });

            migrationBuilder.InsertData(
                table: "user_workspaces",
                columns: new[] { "user_id", "workspace_id", "role" },
                values: new object[,]
                {
                    { new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"), 1 },
                    { new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"), new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d"), 1 },
                    { new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"), 1 },
                    { new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"), 1 },
                    { new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"), 2 },
                    { new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"), 2 },
                    { new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "first_name", "last_name", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"), "John", "Doe", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "john.doe@example.com" },
                    { new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"), "Michael", "Johnson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "michael.johnson@example.com" },
                    { new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"), "Jane", "Smith", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "jane.smith@example.com" },
                    { new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"), "Matthew", "Anderson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "matthew.anderson@example.com" },
                    { new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"), "Sophia", "Wilson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "sophia.wilson@example.com" },
                    { new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"), "Daniel", "Martinez", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "daniel.martinez@example.com" },
                    { new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"), "Emily", "Davis", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "emily.davis@example.com" },
                    { new Guid("d2bf611c-f2d9-47f0-a9d6-1c7703a4becf"), "Olivia", "Garcia", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "olivia.garcia@example.com" },
                    { new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57"), "Chris", "Brown", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "chris.brown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"), "Development", new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a") },
                    { new Guid("1d2128f7-fc01-44c9-b221-1079a6b5594e"), "Sales", new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16") },
                    { new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"), "Marketing", new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8") },
                    { new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d"), "HR", new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57") },
                    { new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d"), "Design", new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("0dad8c65-ce0f-4429-8aff-977b02f7daed"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("a0b80cae-e906-4c2b-813b-9b922e633b5d"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("b7cd139c-f87b-417f-8a39-24732f7146c9"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("e860e23e-3616-4e8d-b517-8e62e92740b6"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("0fbeb34e-0e33-4658-ab7e-e2e88c24ae63"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("521f0ab4-8a2e-4fed-98e7-ef1a681dbaa5"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("5a2e061c-4bc4-4350-9e21-83326ca4abe3"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("5c239a93-75f1-4dd8-a969-6d06cf78fe6a"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("5d11edda-9957-44c7-a32b-51b2f1a7de0a"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("a72df026-d893-469d-b625-5206c131bf30"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("d92858fd-f52a-466c-aab8-c672bff78f23"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("fb69de22-22fa-4117-a74b-139fcf017106"));

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"), new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"), new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"), new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d") });

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d2bf611c-f2d9-47f0-a9d6-1c7703a4becf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("1d2128f7-fc01-44c9-b221-1079a6b5594e"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d"));

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
    }
}
