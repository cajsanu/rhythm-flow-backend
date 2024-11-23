using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class OtherEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateOnly>(
                name: "deadline",
                table: "tickets",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "start_date",
                table: "projects",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "end_date",
                table: "projects",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "id", "description", "end_date", "name", "start_date", "status", "workspace_id" },
                values: new object[,]
                {
                    { new Guid("1b50c89e-b515-452d-ad4f-36c9a44b0be7"), "Revamp Website Design", new DateOnly(2025, 1, 7), "Gamma", new DateOnly(2024, 11, 26), "InProgress", new Guid("c5f035ce-0d46-449f-94fb-05183bdec109") },
                    { new Guid("3841bee7-4836-473b-b291-b94f81e1f931"), "Launch Mobile App", new DateOnly(2025, 2, 21), "Delta", new DateOnly(2024, 11, 30), "InProgress", new Guid("2469dd67-107f-41e1-a078-68e76373455a") },
                    { new Guid("b22009e6-13e5-4bac-b14f-ff027cf68e2a"), "Optimize Data Pipeline", new DateOnly(2025, 2, 11), "Zeta", new DateOnly(2024, 12, 3), "InProgress", new Guid("a74f8710-771f-49ce-ac68-276e240a90ba") },
                    { new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"), "Develop AI Assistant", new DateOnly(2025, 1, 22), "Beta", new DateOnly(2024, 11, 28), "NotStarted", new Guid("9039f98b-ab5b-4ccd-8068-8a6272d7c381") },
                    { new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"), "Conquer the Galaxy", new DateOnly(2025, 1, 12), "Alpha", new DateOnly(2024, 11, 25), "InProgress", new Guid("7a5d2a8f-b69d-4c87-8ec7-dc850b8527b0") },
                    { new Guid("e5235dde-f3f5-475d-9e0b-1a9749c41eb0"), "Implement Cloud Migration", new DateOnly(2025, 3, 23), "Epsilon", new DateOnly(2024, 11, 24), "Cancelled", new Guid("a74f8710-771f-49ce-ac68-276e240a90ba") }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "deadline", "description", "priority", "project_id", "status", "title", "type" },
                values: new object[,]
                {
                    { new Guid("63c2f501-55c8-4622-b11f-5cf3211a8a8c"), new DateOnly(2024, 11, 30), "Plan onboarding session for new hires", "Medium", new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"), "NotStarted", "Schedule Training", 2 },
                    { new Guid("71eff306-1522-4af6-b3c9-51c8eec699ba"), new DateOnly(2024, 12, 3), "Enhance performance of existing API calls", "High", new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"), "InProgress", "Optimize API", 1 },
                    { new Guid("889d3814-b78d-400d-bc84-ad52d9a587f3"), new DateOnly(2024, 11, 26), "Resolve authentication error", "High", new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"), "InProgress", "Fix Login Issue", 0 },
                    { new Guid("b30583ba-f4d6-4104-85c8-513ef467b4d1"), new DateOnly(2024, 12, 7), "Create wireframe for new landing page", "Medium", new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"), "Cancelled", "Design Landing Page", 1 },
                    { new Guid("b6032f2b-c0ca-46a6-b3ce-173e70d27a38"), new DateOnly(2024, 12, 23), "Review and update policy document", "Low", new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"), "NotStarted", "Update Privacy Policy", 2 },
                    { new Guid("b86afca9-9615-48d2-9be5-848718b9ef05"), new DateOnly(2024, 12, 14), "Implement dark mode toggle for Users", "High", new Guid("e5235dde-f3f5-475d-9e0b-1a9749c41eb0"), "Cancelled", "Add Dark Mode", 0 },
                    { new Guid("bc58a4c8-c938-4032-a342-db70466fd20b"), new DateOnly(2024, 11, 30), "using Postgres", "High", new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"), "InProgress", "Create Database", 0 },
                    { new Guid("c1c9b408-ae0b-4d65-b9ef-f42e61485ccc"), new DateOnly(2024, 11, 28), "Fix issue with incorrect data rendering", "High", new Guid("b22009e6-13e5-4bac-b14f-ff027cf68e2a"), "InProgress", "Bug in Report Generation", 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password_hash", "user_email" },
                values: new object[,]
                {
                    { new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9"), "passwordHash123", "jane.smith@example.com" },
                    { new Guid("3e890aa4-79fd-40f3-b2ba-45bb6855b9a7"), "hashedPass987", "daniel.martinez@example.com" },
                    { new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b"), "passwordHash", "john.doe@example.com" },
                    { new Guid("70e668e2-1889-4f5b-b2f9-2468a051d515"), "hashPass753", "matthew.anderson@example.com" },
                    { new Guid("746db305-b08b-4fd9-bca5-ca145a975e03"), "encryptedPass654", "sophia.wilson@example.com" },
                    { new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac"), "hashedPassword789", "emily.davis@example.com" },
                    { new Guid("ca44fa46-695b-4646-93da-379ca2783cba"), "passHash321", "chris.brown@example.com" },
                    { new Guid("f32c6777-9aed-463e-af44-d2e1a4248e33"), "passwordHash159", "olivia.garcia@example.com" },
                    { new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc"), "securePass456", "michael.johnson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "workspaces",
                columns: new[] { "id", "name", "owner_id" },
                values: new object[,]
                {
                    { new Guid("2469dd67-107f-41e1-a078-68e76373455a"), "Sales", new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac") },
                    { new Guid("7a5d2a8f-b69d-4c87-8ec7-dc850b8527b0"), "Marketing", new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b") },
                    { new Guid("9039f98b-ab5b-4ccd-8068-8a6272d7c381"), "Development", new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9") },
                    { new Guid("a74f8710-771f-49ce-ac68-276e240a90ba"), "HR", new Guid("ca44fa46-695b-4646-93da-379ca2783cba") },
                    { new Guid("c5f035ce-0d46-449f-94fb-05183bdec109"), "Design", new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("1b50c89e-b515-452d-ad4f-36c9a44b0be7"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("3841bee7-4836-473b-b291-b94f81e1f931"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("b22009e6-13e5-4bac-b14f-ff027cf68e2a"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("e5235dde-f3f5-475d-9e0b-1a9749c41eb0"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("63c2f501-55c8-4622-b11f-5cf3211a8a8c"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("71eff306-1522-4af6-b3c9-51c8eec699ba"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("889d3814-b78d-400d-bc84-ad52d9a587f3"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("b30583ba-f4d6-4104-85c8-513ef467b4d1"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("b6032f2b-c0ca-46a6-b3ce-173e70d27a38"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("b86afca9-9615-48d2-9be5-848718b9ef05"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("bc58a4c8-c938-4032-a342-db70466fd20b"));

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: new Guid("c1c9b408-ae0b-4d65-b9ef-f42e61485ccc"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3e890aa4-79fd-40f3-b2ba-45bb6855b9a7"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("70e668e2-1889-4f5b-b2f9-2468a051d515"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("746db305-b08b-4fd9-bca5-ca145a975e03"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ca44fa46-695b-4646-93da-379ca2783cba"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f32c6777-9aed-463e-af44-d2e1a4248e33"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("2469dd67-107f-41e1-a078-68e76373455a"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("7a5d2a8f-b69d-4c87-8ec7-dc850b8527b0"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("9039f98b-ab5b-4ccd-8068-8a6272d7c381"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("a74f8710-771f-49ce-ac68-276e240a90ba"));

            migrationBuilder.DeleteData(
                table: "workspaces",
                keyColumn: "id",
                keyValue: new Guid("c5f035ce-0d46-449f-94fb-05183bdec109"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "deadline",
                table: "tickets",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_date",
                table: "projects",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "projects",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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
    }
}
