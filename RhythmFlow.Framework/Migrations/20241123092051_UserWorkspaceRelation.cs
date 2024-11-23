using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RhythmFlow.Framework.Migrations
{
    /// <inheritdoc />
    public partial class UserWorkspaceRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
