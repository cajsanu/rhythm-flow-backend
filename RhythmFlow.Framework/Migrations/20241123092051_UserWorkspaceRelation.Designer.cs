﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RhythmFlow.Framework.src.Data;

#nullable disable

namespace RhythmFlow.Framework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241123092051_UserWorkspaceRelation")]
    partial class UserWorkspaceRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"),
                            Description = "Conquer the Galaxy",
                            EndDate = new DateOnly(2025, 1, 12),
                            Name = "Alpha",
                            StartDate = new DateOnly(2024, 11, 25),
                            Status = "InProgress",
                            WorkspaceId = new Guid("8d78d550-1748-457f-9875-945203f6f966")
                        },
                        new
                        {
                            Id = new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"),
                            Description = "Develop AI Assistant",
                            EndDate = new DateOnly(2025, 1, 22),
                            Name = "Beta",
                            StartDate = new DateOnly(2024, 11, 28),
                            Status = "NotStarted",
                            WorkspaceId = new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41")
                        },
                        new
                        {
                            Id = new Guid("40e02149-c456-4a6f-a96a-e3861aeb316f"),
                            Description = "Revamp Website Design",
                            EndDate = new DateOnly(2025, 1, 7),
                            Name = "Gamma",
                            StartDate = new DateOnly(2024, 11, 26),
                            Status = "InProgress",
                            WorkspaceId = new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef")
                        },
                        new
                        {
                            Id = new Guid("d9d6a494-b01d-48fb-876f-e1cc0247ef08"),
                            Description = "Launch Mobile App",
                            EndDate = new DateOnly(2025, 2, 21),
                            Name = "Delta",
                            StartDate = new DateOnly(2024, 11, 30),
                            Status = "InProgress",
                            WorkspaceId = new Guid("a72a8d11-39b3-4faf-9827-73a9d1275519")
                        },
                        new
                        {
                            Id = new Guid("8653c883-55ce-41f5-83bc-a32f1ed433b8"),
                            Description = "Implement Cloud Migration",
                            EndDate = new DateOnly(2025, 3, 23),
                            Name = "Epsilon",
                            StartDate = new DateOnly(2024, 11, 24),
                            Status = "Cancelled",
                            WorkspaceId = new Guid("c994312e-ccd5-4539-849d-85f7c839a642")
                        },
                        new
                        {
                            Id = new Guid("a13c4bdf-53df-4f75-835f-243be4418d2e"),
                            Description = "Optimize Data Pipeline",
                            EndDate = new DateOnly(2025, 2, 11),
                            Name = "Zeta",
                            StartDate = new DateOnly(2024, 12, 3),
                            Status = "InProgress",
                            WorkspaceId = new Guid("c994312e-ccd5-4539-849d-85f7c839a642")
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
                            Id = new Guid("0e98de84-b57c-47b4-9adc-2cd5777a084c"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "using Postgres",
                            Priority = "High",
                            ProjectId = new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"),
                            Status = "InProgress",
                            Title = "Create Database",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("17aada48-fc6f-4e90-8fcf-706c0267e1c6"),
                            Deadline = new DateOnly(2024, 11, 26),
                            Description = "Resolve authentication error",
                            Priority = "High",
                            ProjectId = new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"),
                            Status = "InProgress",
                            Title = "Fix Login Issue",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("16fabca7-dcae-480c-b825-b67622edee86"),
                            Deadline = new DateOnly(2024, 12, 7),
                            Description = "Create wireframe for new landing page",
                            Priority = "Medium",
                            ProjectId = new Guid("1820894c-0a48-4715-b84e-8e8438a4d42b"),
                            Status = "Cancelled",
                            Title = "Design Landing Page",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("b64b10e6-cb1d-45f3-a8e0-ce46dc3c59cd"),
                            Deadline = new DateOnly(2024, 12, 23),
                            Description = "Review and update policy document",
                            Priority = "Low",
                            ProjectId = new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"),
                            Status = "NotStarted",
                            Title = "Update Privacy Policy",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("6922f991-4523-481b-8d7f-3d9e90df6762"),
                            Deadline = new DateOnly(2024, 12, 3),
                            Description = "Enhance performance of existing API calls",
                            Priority = "High",
                            ProjectId = new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"),
                            Status = "InProgress",
                            Title = "Optimize API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("a7cb3a68-db21-474f-859c-0c1d0210eb8b"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "Plan onboarding session for new hires",
                            Priority = "Medium",
                            ProjectId = new Guid("da48a43a-435a-461b-ac9e-2c9cdaf8e6af"),
                            Status = "NotStarted",
                            Title = "Schedule Training",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("94aa18ab-8280-4ac5-983a-4596b1f1bf39"),
                            Deadline = new DateOnly(2024, 12, 14),
                            Description = "Implement dark mode toggle for Users",
                            Priority = "High",
                            ProjectId = new Guid("8653c883-55ce-41f5-83bc-a32f1ed433b8"),
                            Status = "Cancelled",
                            Title = "Add Dark Mode",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("4ebe4156-c4f2-468a-bb46-f2e872f93f63"),
                            Deadline = new DateOnly(2024, 11, 28),
                            Description = "Fix issue with incorrect data rendering",
                            Priority = "High",
                            ProjectId = new Guid("a13c4bdf-53df-4f75-835f-243be4418d2e"),
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
                            Id = new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"),
                            PasswordHash = "passwordHash"
                        },
                        new
                        {
                            Id = new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"),
                            PasswordHash = "passwordHash123"
                        },
                        new
                        {
                            Id = new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"),
                            PasswordHash = "securePass456"
                        },
                        new
                        {
                            Id = new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"),
                            PasswordHash = "hashedPassword789"
                        },
                        new
                        {
                            Id = new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2"),
                            PasswordHash = "passHash321"
                        },
                        new
                        {
                            Id = new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"),
                            PasswordHash = "encryptedPass654"
                        },
                        new
                        {
                            Id = new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"),
                            PasswordHash = "hashedPass987"
                        },
                        new
                        {
                            Id = new Guid("86836b55-c5b4-4a8e-b6c1-d8c797cb7a28"),
                            PasswordHash = "passwordHash159"
                        },
                        new
                        {
                            Id = new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"),
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

                    b.HasData(
                        new
                        {
                            UserId = new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"),
                            WorkspaceId = new Guid("8d78d550-1748-457f-9875-945203f6f966"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"),
                            WorkspaceId = new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"),
                            WorkspaceId = new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"),
                            WorkspaceId = new Guid("8d78d550-1748-457f-9875-945203f6f966"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"),
                            WorkspaceId = new Guid("8d78d550-1748-457f-9875-945203f6f966"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"),
                            WorkspaceId = new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"),
                            Role = 2
                        },
                        new
                        {
                            UserId = new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"),
                            WorkspaceId = new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"),
                            Role = 2
                        });
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
                            Id = new Guid("8d78d550-1748-457f-9875-945203f6f966"),
                            Name = "Marketing",
                            OwnerId = new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da")
                        },
                        new
                        {
                            Id = new Guid("fe01579b-ab97-4e91-a8fb-6b6597e2af41"),
                            Name = "Development",
                            OwnerId = new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d")
                        },
                        new
                        {
                            Id = new Guid("6c0f5f47-65a6-4f87-a5f2-7ba9f35064ef"),
                            Name = "Design",
                            OwnerId = new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216")
                        },
                        new
                        {
                            Id = new Guid("a72a8d11-39b3-4faf-9827-73a9d1275519"),
                            Name = "Sales",
                            OwnerId = new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15")
                        },
                        new
                        {
                            Id = new Guid("c994312e-ccd5-4539-849d-85f7c839a642"),
                            Name = "HR",
                            OwnerId = new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2")
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
                                    UserId = new Guid("1f5bdf97-1baa-4c7f-a52a-fea1a36110da"),
                                    Value = "john.doe@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("4093cb23-3c9d-444b-91f4-5cf66b000b8d"),
                                    Value = "jane.smith@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("8695e399-ff7d-4217-a7f5-e2c2249bc216"),
                                    Value = "michael.johnson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("0b7df67d-87b5-4f4c-adc0-a2724a881b15"),
                                    Value = "emily.davis@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("18d415de-c7d3-4319-ad18-14c6ef48cfa2"),
                                    Value = "chris.brown@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("86f6e622-a7f6-4703-b9b0-cc9e942d4da8"),
                                    Value = "sophia.wilson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("2521b59c-0885-48e5-afa3-f4afbfb8a2a3"),
                                    Value = "daniel.martinez@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("86836b55-c5b4-4a8e-b6c1-d8c797cb7a28"),
                                    Value = "olivia.garcia@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("ba314735-1278-44c4-b8a9-105ded92bf04"),
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
