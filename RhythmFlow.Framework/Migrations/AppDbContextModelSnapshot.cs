﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RhythmFlow.Framework.src.Data;

#nullable disable

namespace RhythmFlow.Framework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<Guid>("ProjectsId")
                        .HasColumnType("uuid")
                        .HasColumnName("projects_id");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid")
                        .HasColumnName("users_id");

                    b.HasKey("ProjectsId", "UsersId")
                        .HasName("pk_project_user");

                    b.HasIndex("UsersId")
                        .HasDatabaseName("ix_project_user_users_id");

                    b.ToTable("project_user", (string)null);
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<Guid>("WorkspaceId")
                        .HasColumnType("uuid")
                        .HasColumnName("workspace_id");

                    b.HasKey("Id")
                        .HasName("pk_projects");

                    b.ToTable("projects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"),
                            Description = "Conquer the Galaxy",
                            EndDate = new DateOnly(2025, 1, 12),
                            Name = "Alpha",
                            StartDate = new DateOnly(2024, 11, 25),
                            Status = "InProgress",
                            WorkspaceId = new Guid("7a5d2a8f-b69d-4c87-8ec7-dc850b8527b0")
                        },
                        new
                        {
                            Id = new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"),
                            Description = "Develop AI Assistant",
                            EndDate = new DateOnly(2025, 1, 22),
                            Name = "Beta",
                            StartDate = new DateOnly(2024, 11, 28),
                            Status = "NotStarted",
                            WorkspaceId = new Guid("9039f98b-ab5b-4ccd-8068-8a6272d7c381")
                        },
                        new
                        {
                            Id = new Guid("1b50c89e-b515-452d-ad4f-36c9a44b0be7"),
                            Description = "Revamp Website Design",
                            EndDate = new DateOnly(2025, 1, 7),
                            Name = "Gamma",
                            StartDate = new DateOnly(2024, 11, 26),
                            Status = "InProgress",
                            WorkspaceId = new Guid("c5f035ce-0d46-449f-94fb-05183bdec109")
                        },
                        new
                        {
                            Id = new Guid("3841bee7-4836-473b-b291-b94f81e1f931"),
                            Description = "Launch Mobile App",
                            EndDate = new DateOnly(2025, 2, 21),
                            Name = "Delta",
                            StartDate = new DateOnly(2024, 11, 30),
                            Status = "InProgress",
                            WorkspaceId = new Guid("2469dd67-107f-41e1-a078-68e76373455a")
                        },
                        new
                        {
                            Id = new Guid("e5235dde-f3f5-475d-9e0b-1a9749c41eb0"),
                            Description = "Implement Cloud Migration",
                            EndDate = new DateOnly(2025, 3, 23),
                            Name = "Epsilon",
                            StartDate = new DateOnly(2024, 11, 24),
                            Status = "Cancelled",
                            WorkspaceId = new Guid("a74f8710-771f-49ce-ac68-276e240a90ba")
                        },
                        new
                        {
                            Id = new Guid("b22009e6-13e5-4bac-b14f-ff027cf68e2a"),
                            Description = "Optimize Data Pipeline",
                            EndDate = new DateOnly(2025, 2, 11),
                            Name = "Zeta",
                            StartDate = new DateOnly(2024, 12, 3),
                            Status = "InProgress",
                            WorkspaceId = new Guid("a74f8710-771f-49ce-ac68-276e240a90ba")
                        });
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly>("Deadline")
                        .HasColumnType("date")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("priority");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_tickets");

                    b.ToTable("tickets", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc58a4c8-c938-4032-a342-db70466fd20b"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "using Postgres",
                            Priority = "High",
                            ProjectId = new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"),
                            Status = "InProgress",
                            Title = "Create Database",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("889d3814-b78d-400d-bc84-ad52d9a587f3"),
                            Deadline = new DateOnly(2024, 11, 26),
                            Description = "Resolve authentication error",
                            Priority = "High",
                            ProjectId = new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"),
                            Status = "InProgress",
                            Title = "Fix Login Issue",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("b30583ba-f4d6-4104-85c8-513ef467b4d1"),
                            Deadline = new DateOnly(2024, 12, 7),
                            Description = "Create wireframe for new landing page",
                            Priority = "Medium",
                            ProjectId = new Guid("da7b14fe-371c-40c1-a930-515f2ee17da2"),
                            Status = "Cancelled",
                            Title = "Design Landing Page",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("b6032f2b-c0ca-46a6-b3ce-173e70d27a38"),
                            Deadline = new DateOnly(2024, 12, 23),
                            Description = "Review and update policy document",
                            Priority = "Low",
                            ProjectId = new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"),
                            Status = "NotStarted",
                            Title = "Update Privacy Policy",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("71eff306-1522-4af6-b3c9-51c8eec699ba"),
                            Deadline = new DateOnly(2024, 12, 3),
                            Description = "Enhance performance of existing API calls",
                            Priority = "High",
                            ProjectId = new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"),
                            Status = "InProgress",
                            Title = "Optimize API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("63c2f501-55c8-4622-b11f-5cf3211a8a8c"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "Plan onboarding session for new hires",
                            Priority = "Medium",
                            ProjectId = new Guid("b4b5f6c7-7480-4eb9-bb44-b3409c50822e"),
                            Status = "NotStarted",
                            Title = "Schedule Training",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("b86afca9-9615-48d2-9be5-848718b9ef05"),
                            Deadline = new DateOnly(2024, 12, 14),
                            Description = "Implement dark mode toggle for Users",
                            Priority = "High",
                            ProjectId = new Guid("e5235dde-f3f5-475d-9e0b-1a9749c41eb0"),
                            Status = "Cancelled",
                            Title = "Add Dark Mode",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("c1c9b408-ae0b-4d65-b9ef-f42e61485ccc"),
                            Deadline = new DateOnly(2024, 11, 28),
                            Description = "Fix issue with incorrect data rendering",
                            Priority = "High",
                            ProjectId = new Guid("b22009e6-13e5-4bac-b14f-ff027cf68e2a"),
                            Status = "InProgress",
                            Title = "Bug in Report Generation",
                            Type = 1
                        });
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b"),
                            PasswordHash = "passwordHash"
                        },
                        new
                        {
                            Id = new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9"),
                            PasswordHash = "passwordHash123"
                        },
                        new
                        {
                            Id = new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc"),
                            PasswordHash = "securePass456"
                        },
                        new
                        {
                            Id = new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac"),
                            PasswordHash = "hashedPassword789"
                        },
                        new
                        {
                            Id = new Guid("ca44fa46-695b-4646-93da-379ca2783cba"),
                            PasswordHash = "passHash321"
                        },
                        new
                        {
                            Id = new Guid("746db305-b08b-4fd9-bca5-ca145a975e03"),
                            PasswordHash = "encryptedPass654"
                        },
                        new
                        {
                            Id = new Guid("3e890aa4-79fd-40f3-b2ba-45bb6855b9a7"),
                            PasswordHash = "hashedPass987"
                        },
                        new
                        {
                            Id = new Guid("f32c6777-9aed-463e-af44-d2e1a4248e33"),
                            PasswordHash = "passwordHash159"
                        },
                        new
                        {
                            Id = new Guid("70e668e2-1889-4f5b-b2f9-2468a051d515"),
                            PasswordHash = "hashPass753"
                        });
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.UserWorkspace", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<Guid>("WorkspaceId")
                        .HasColumnType("uuid")
                        .HasColumnName("workspace_id");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("role");

                    b.HasKey("UserId", "WorkspaceId")
                        .HasName("pk_user_workspaces");

                    b.ToTable("user_workspaces", (string)null);
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.Workspace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid")
                        .HasColumnName("owner_id");

                    b.HasKey("Id")
                        .HasName("pk_workspaces");

                    b.ToTable("workspaces", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a5d2a8f-b69d-4c87-8ec7-dc850b8527b0"),
                            Name = "Marketing",
                            OwnerId = new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b")
                        },
                        new
                        {
                            Id = new Guid("9039f98b-ab5b-4ccd-8068-8a6272d7c381"),
                            Name = "Development",
                            OwnerId = new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9")
                        },
                        new
                        {
                            Id = new Guid("c5f035ce-0d46-449f-94fb-05183bdec109"),
                            Name = "Design",
                            OwnerId = new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc")
                        },
                        new
                        {
                            Id = new Guid("2469dd67-107f-41e1-a078-68e76373455a"),
                            Name = "Sales",
                            OwnerId = new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac")
                        },
                        new
                        {
                            Id = new Guid("a74f8710-771f-49ce-ac68-276e240a90ba"),
                            Name = "HR",
                            OwnerId = new Guid("ca44fa46-695b-4646-93da-379ca2783cba")
                        });
                });

            modelBuilder.Entity("TicketUser", b =>
                {
                    b.Property<Guid>("TicketsId")
                        .HasColumnType("uuid")
                        .HasColumnName("tickets_id");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid")
                        .HasColumnName("users_id");

                    b.HasKey("TicketsId", "UsersId")
                        .HasName("pk_ticket_user");

                    b.HasIndex("UsersId")
                        .HasDatabaseName("ix_ticket_user_users_id");

                    b.ToTable("ticket_user", (string)null);
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("RhythmFlow.Domain.src.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_user_projects_projects_id");

                    b.HasOne("RhythmFlow.Domain.src.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_user_users_users_id");
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.User", b =>
                {
                    b.OwnsOne("RhythmFlow.Domain.src.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("user_email");

                            b1.HasKey("UserId");

                            b1.ToTable("users");

                            b1.WithOwner()
                                .HasForeignKey("UserId")
                                .HasConstraintName("fk_users_users_id");

                            b1.HasData(
                                new
                                {
                                    UserId = new Guid("58e2789e-a4e7-4c6e-87ea-3354854e987b"),
                                    Value = "john.doe@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("3ac3df34-b0d3-421e-8b29-66d27edb6cc9"),
                                    Value = "jane.smith@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("fba33083-f74e-455e-9fc4-11ffa4a857dc"),
                                    Value = "michael.johnson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("9f671b97-4ac4-43cf-ae62-4bd357b482ac"),
                                    Value = "emily.davis@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("ca44fa46-695b-4646-93da-379ca2783cba"),
                                    Value = "chris.brown@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("746db305-b08b-4fd9-bca5-ca145a975e03"),
                                    Value = "sophia.wilson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("3e890aa4-79fd-40f3-b2ba-45bb6855b9a7"),
                                    Value = "daniel.martinez@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("f32c6777-9aed-463e-af44-d2e1a4248e33"),
                                    Value = "olivia.garcia@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("70e668e2-1889-4f5b-b2f9-2468a051d515"),
                                    Value = "matthew.anderson@example.com"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("TicketUser", b =>
                {
                    b.HasOne("RhythmFlow.Domain.src.Entities.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_ticket_user_tickets_tickets_id");

                    b.HasOne("RhythmFlow.Domain.src.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_ticket_user_users_users_id");
                });
#pragma warning restore 612, 618
        }
    }
}
