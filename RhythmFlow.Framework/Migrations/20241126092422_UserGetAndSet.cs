using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class UserGetAndSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0467476d-6c6f-4cb1-9806-af8dc934d5d8"), "Revamp Website Design", new DateOnly(2025, 1, 10), "Gamma", new DateOnly(2024, 11, 29), "InProgress", new Guid("9e2bbe3e-663b-4d08-bb99-747171f7bd98") },
                    { new Guid("0bc75be7-b64e-42de-9651-0afb28842a76"), "Optimize Data Pipeline", new DateOnly(2025, 2, 14), "Zeta", new DateOnly(2024, 12, 6), "InProgress", new Guid("3d078d7b-580f-414e-859a-a1fbe67ef928") },
                    { new Guid("b13be132-27d2-418f-9b6a-6e73b2c2a70d"), "Develop AI Assistant", new DateOnly(2025, 1, 25), "Beta", new DateOnly(2024, 12, 1), "NotStarted", new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2") },
                    { new Guid("c94986e9-2dbe-47ba-a895-3c6356e0478c"), "Conquer the Galaxy", new DateOnly(2025, 1, 15), "Alpha", new DateOnly(2024, 11, 28), "InProgress", new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e") },
                    { new Guid("d3276591-9895-4be9-900f-8f0e97c3a6f1"), "Launch Mobile App", new DateOnly(2025, 2, 24), "Delta", new DateOnly(2024, 12, 3), "InProgress", new Guid("a9a95c77-1951-4dc4-a51a-ecb6f3350ecd") },
                    { new Guid("f373bf5f-0f57-4272-b6ff-a6a2a90dede7"), "Implement Cloud Migration", new DateOnly(2025, 3, 26), "Epsilon", new DateOnly(2024, 11, 27), "Cancelled", new Guid("3d078d7b-580f-414e-859a-a1fbe67ef928") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("11a458e5-5b69-4172-94b4-9966801214a8"), new DateOnly(2024, 12, 6), "Enhance performance of existing API calls", "High", new Guid("b13be132-27d2-418f-9b6a-6e73b2c2a70d"), "InProgress", "Optimize API", 1 },
                    { new Guid("12549c20-3790-4c43-a65f-99c24b71f26d"), new DateOnly(2024, 12, 17), "Implement dark mode toggle for Users", "High", new Guid("f373bf5f-0f57-4272-b6ff-a6a2a90dede7"), "Cancelled", "Add Dark Mode", 0 },
                    { new Guid("25c0c7a1-e853-4745-9a1c-b344e6bb0433"), new DateOnly(2024, 12, 3), "using Postgres", "High", new Guid("c94986e9-2dbe-47ba-a895-3c6356e0478c"), "InProgress", "Create Database", 0 },
                    { new Guid("5208d0c1-6e6e-41f5-a59f-3d4ee2239cd8"), new DateOnly(2024, 12, 26), "Review and update policy document", "Low", new Guid("b13be132-27d2-418f-9b6a-6e73b2c2a70d"), "NotStarted", "Update Privacy Policy", 2 },
                    { new Guid("8ace22dc-2e7c-43ca-829c-904bbcdba6dd"), new DateOnly(2024, 12, 10), "Create wireframe for new landing page", "Medium", new Guid("c94986e9-2dbe-47ba-a895-3c6356e0478c"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("af7f355e-0e22-4475-b2a3-3aa249860ae1"), new DateOnly(2024, 12, 3), "Plan onboarding session for new hires", "Medium", new Guid("b13be132-27d2-418f-9b6a-6e73b2c2a70d"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("db02b124-aa2e-4543-b43d-773cc0c19eb1"), new DateOnly(2024, 11, 29), "Resolve authentication error", "High", new Guid("c94986e9-2dbe-47ba-a895-3c6356e0478c"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("f15c17ba-2a89-4f73-997b-e65e1dc3f3f2"), new DateOnly(2024, 12, 1), "Fix issue with incorrect data rendering", "High", new Guid("0bc75be7-b64e-42de-9651-0afb28842a76"), "InProgress", "Bug in Report Generation", 1 }
                });

            migrationBuilder.InsertData(
                table: "user_workspaces",
                columns: new[] { "user_id", "workspace_id", "role" },
                values: new object[,]
                {
                    { new Guid("1099c1a3-a1d5-4825-9730-16c166ada80c"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e"), 1 },
                    { new Guid("45fa9eea-9f76-48cc-b032-4c7594e48067"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2"), 1 },
                    { new Guid("5491094c-4ab2-41d9-8018-8fff919897ba"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e"), 1 },
                    { new Guid("634a2a9f-8353-4aac-9de5-ef2141250d54"), new Guid("9e2bbe3e-663b-4d08-bb99-747171f7bd98"), 1 },
                    { new Guid("6b376c87-51c6-46fd-91ae-5ee926654eb3"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2"), 2 },
                    { new Guid("900357b9-2f96-4cda-b48e-fe3d34307176"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e"), 1 },
                    { new Guid("d18bf358-2ab6-4876-983d-dd6e3a5a6d3c"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2"), 2 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "first_name", "last_name", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("1099c1a3-a1d5-4825-9730-16c166ada80c"), "Matthew", "Anderson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "matthew.anderson@example.com" },
                    { new Guid("45fa9eea-9f76-48cc-b032-4c7594e48067"), "Jane", "Smith", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "jane.smith@example.com" },
                    { new Guid("5491094c-4ab2-41d9-8018-8fff919897ba"), "John", "Doe", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "john.doe@example.com" },
                    { new Guid("634a2a9f-8353-4aac-9de5-ef2141250d54"), "Michael", "Johnson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "michael.johnson@example.com" },
                    { new Guid("6b376c87-51c6-46fd-91ae-5ee926654eb3"), "Daniel", "Martinez", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "daniel.martinez@example.com" },
                    { new Guid("83f43da3-dc36-4ce8-ad49-0673b354e8bb"), "Chris", "Brown", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "chris.brown@example.com" },
                    { new Guid("900357b9-2f96-4cda-b48e-fe3d34307176"), "Emily", "Davis", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "emily.davis@example.com" },
                    { new Guid("d18bf358-2ab6-4876-983d-dd6e3a5a6d3c"), "Sophia", "Wilson", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "sophia.wilson@example.com" },
                    { new Guid("db6ffd0c-363e-4340-a4ab-e6e7e4c703e1"), "Olivia", "Garcia", "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi", "olivia.garcia@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("3d078d7b-580f-414e-859a-a1fbe67ef928"), "HR", new Guid("83f43da3-dc36-4ce8-ad49-0673b354e8bb") },
                    { new Guid("9e2bbe3e-663b-4d08-bb99-747171f7bd98"), "Design", new Guid("634a2a9f-8353-4aac-9de5-ef2141250d54") },
                    { new Guid("a9a95c77-1951-4dc4-a51a-ecb6f3350ecd"), "Sales", new Guid("900357b9-2f96-4cda-b48e-fe3d34307176") },
                    { new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e"), "Marketing", new Guid("5491094c-4ab2-41d9-8018-8fff919897ba") },
                    { new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2"), "Development", new Guid("45fa9eea-9f76-48cc-b032-4c7594e48067") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("0467476d-6c6f-4cb1-9806-af8dc934d5d8"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("0bc75be7-b64e-42de-9651-0afb28842a76"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("b13be132-27d2-418f-9b6a-6e73b2c2a70d"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("c94986e9-2dbe-47ba-a895-3c6356e0478c"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("d3276591-9895-4be9-900f-8f0e97c3a6f1"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("f373bf5f-0f57-4272-b6ff-a6a2a90dede7"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("11a458e5-5b69-4172-94b4-9966801214a8"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("12549c20-3790-4c43-a65f-99c24b71f26d"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("25c0c7a1-e853-4745-9a1c-b344e6bb0433"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("5208d0c1-6e6e-41f5-a59f-3d4ee2239cd8"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("8ace22dc-2e7c-43ca-829c-904bbcdba6dd"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("af7f355e-0e22-4475-b2a3-3aa249860ae1"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("db02b124-aa2e-4543-b43d-773cc0c19eb1"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("f15c17ba-2a89-4f73-997b-e65e1dc3f3f2"));

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("1099c1a3-a1d5-4825-9730-16c166ada80c"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("45fa9eea-9f76-48cc-b032-4c7594e48067"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("5491094c-4ab2-41d9-8018-8fff919897ba"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("634a2a9f-8353-4aac-9de5-ef2141250d54"), new Guid("9e2bbe3e-663b-4d08-bb99-747171f7bd98") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("6b376c87-51c6-46fd-91ae-5ee926654eb3"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("900357b9-2f96-4cda-b48e-fe3d34307176"), new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e") });

            migrationBuilder.DeleteData(
                table: "user_workspaces",
                keyColumns: new[] { "user_id", "workspace_id" },
                keyValues: new object[] { new Guid("d18bf358-2ab6-4876-983d-dd6e3a5a6d3c"), new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2") });

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1099c1a3-a1d5-4825-9730-16c166ada80c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("45fa9eea-9f76-48cc-b032-4c7594e48067"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5491094c-4ab2-41d9-8018-8fff919897ba"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("634a2a9f-8353-4aac-9de5-ef2141250d54"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6b376c87-51c6-46fd-91ae-5ee926654eb3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("83f43da3-dc36-4ce8-ad49-0673b354e8bb"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("900357b9-2f96-4cda-b48e-fe3d34307176"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d18bf358-2ab6-4876-983d-dd6e3a5a6d3c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("db6ffd0c-363e-4340-a4ab-e6e7e4c703e1"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("3d078d7b-580f-414e-859a-a1fbe67ef928"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("9e2bbe3e-663b-4d08-bb99-747171f7bd98"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("a9a95c77-1951-4dc4-a51a-ecb6f3350ecd"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("e06bf46b-0508-403c-963f-5b4d4287de7e"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("f3538842-3d20-482a-be6e-fe8d77b99df2"));

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
    }
}
