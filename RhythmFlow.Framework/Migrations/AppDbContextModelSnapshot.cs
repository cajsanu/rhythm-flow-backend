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
                            Id = new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"),
                            Description = "Conquer the Galaxy",
                            EndDate = new DateOnly(2025, 1, 12),
                            Name = "Alpha",
                            StartDate = new DateOnly(2024, 11, 25),
                            Status = "InProgress",
                            WorkspaceId = new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2")
                        },
                        new
                        {
                            Id = new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"),
                            Description = "Develop AI Assistant",
                            EndDate = new DateOnly(2025, 1, 22),
                            Name = "Beta",
                            StartDate = new DateOnly(2024, 11, 28),
                            Status = "NotStarted",
                            WorkspaceId = new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9")
                        },
                        new
                        {
                            Id = new Guid("2a4f7751-6e2f-4848-9939-1c37a3be3ea7"),
                            Description = "Revamp Website Design",
                            EndDate = new DateOnly(2025, 1, 7),
                            Name = "Gamma",
                            StartDate = new DateOnly(2024, 11, 26),
                            Status = "InProgress",
                            WorkspaceId = new Guid("2af8941b-ba86-4fff-9063-ad77493ba820")
                        },
                        new
                        {
                            Id = new Guid("92f670db-85d3-4b9a-bc71-596cc705cbd6"),
                            Description = "Launch Mobile App",
                            EndDate = new DateOnly(2025, 2, 21),
                            Name = "Delta",
                            StartDate = new DateOnly(2024, 11, 30),
                            Status = "InProgress",
                            WorkspaceId = new Guid("8e283f09-2057-4a72-ba7a-bef88a4a125f")
                        },
                        new
                        {
                            Id = new Guid("266649a6-03b6-46c0-b039-c324229ba5e7"),
                            Description = "Implement Cloud Migration",
                            EndDate = new DateOnly(2025, 3, 23),
                            Name = "Epsilon",
                            StartDate = new DateOnly(2024, 11, 24),
                            Status = "Cancelled",
                            WorkspaceId = new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd")
                        },
                        new
                        {
                            Id = new Guid("a67a2929-fc12-4dd4-8efc-8ccc59949091"),
                            Description = "Optimize Data Pipeline",
                            EndDate = new DateOnly(2025, 2, 11),
                            Name = "Zeta",
                            StartDate = new DateOnly(2024, 12, 3),
                            Status = "InProgress",
                            WorkspaceId = new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd")
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
                            Id = new Guid("96a78659-bdbd-4c68-9cf7-327a950a5bde"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "using Postgres",
                            Priority = "High",
                            ProjectId = new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"),
                            Status = "InProgress",
                            Title = "Create Database",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("48909356-7bc0-481b-a9f5-4bc62dadfcac"),
                            Deadline = new DateOnly(2024, 11, 26),
                            Description = "Resolve authentication error",
                            Priority = "High",
                            ProjectId = new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"),
                            Status = "InProgress",
                            Title = "Fix Login Issue",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("424d7a17-b1b0-4997-8540-99feec60ccd8"),
                            Deadline = new DateOnly(2024, 12, 7),
                            Description = "Create wireframe for new landing page",
                            Priority = "Medium",
                            ProjectId = new Guid("fa4f734b-6eea-4341-bb8c-bd0da8376433"),
                            Status = "Cancelled",
                            Title = "Design Landing Page",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("44c8d122-5216-4e8e-b723-0e52b8fcd5ad"),
                            Deadline = new DateOnly(2024, 12, 23),
                            Description = "Review and update policy document",
                            Priority = "Low",
                            ProjectId = new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"),
                            Status = "NotStarted",
                            Title = "Update Privacy Policy",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("fe8ca3b0-416b-4ebc-8905-e264df89d71e"),
                            Deadline = new DateOnly(2024, 12, 3),
                            Description = "Enhance performance of existing API calls",
                            Priority = "High",
                            ProjectId = new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"),
                            Status = "InProgress",
                            Title = "Optimize API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("b0daa214-79c7-4c85-8be8-b91df3ca3ee1"),
                            Deadline = new DateOnly(2024, 11, 30),
                            Description = "Plan onboarding session for new hires",
                            Priority = "Medium",
                            ProjectId = new Guid("17392215-72a4-4388-bf73-8ecc56eb6ed2"),
                            Status = "NotStarted",
                            Title = "Schedule Training",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("5af13a4f-7c92-4f01-ad25-30130e97cdd9"),
                            Deadline = new DateOnly(2024, 12, 14),
                            Description = "Implement dark mode toggle for Users",
                            Priority = "High",
                            ProjectId = new Guid("266649a6-03b6-46c0-b039-c324229ba5e7"),
                            Status = "Cancelled",
                            Title = "Add Dark Mode",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("2af1f7f8-f480-4c1e-afe7-42d22f90ba2e"),
                            Deadline = new DateOnly(2024, 11, 28),
                            Description = "Fix issue with incorrect data rendering",
                            Priority = "High",
                            ProjectId = new Guid("a67a2929-fc12-4dd4-8efc-8ccc59949091"),
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

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
                            Id = new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"),
                            FirstName = "John",
                            LastName = "Doe",
                            PasswordHash = "passwordHash"
                        },
                        new
                        {
                            Id = new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"),
                            FirstName = "Jane",
                            LastName = "Smith",
                            PasswordHash = "passwordHash123"
                        },
                        new
                        {
                            Id = new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"),
                            FirstName = "Michael",
                            LastName = "Johnson",
                            PasswordHash = "securePass456"
                        },
                        new
                        {
                            Id = new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"),
                            FirstName = "Emily",
                            LastName = "Davis",
                            PasswordHash = "hashedPassword789"
                        },
                        new
                        {
                            Id = new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c"),
                            FirstName = "Chris",
                            LastName = "Brown",
                            PasswordHash = "passHash321"
                        },
                        new
                        {
                            Id = new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"),
                            FirstName = "Sophia",
                            LastName = "Wilson",
                            PasswordHash = "encryptedPass654"
                        },
                        new
                        {
                            Id = new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"),
                            FirstName = "Daniel",
                            LastName = "Martinez",
                            PasswordHash = "hashedPass987"
                        },
                        new
                        {
                            Id = new Guid("3f30dd69-54e4-4331-839d-088044a173ba"),
                            FirstName = "Olivia",
                            LastName = "Garcia",
                            PasswordHash = "passwordHash159"
                        },
                        new
                        {
                            Id = new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"),
                            FirstName = "Matthew",
                            LastName = "Anderson",
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
                            UserId = new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"),
                            WorkspaceId = new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"),
                            WorkspaceId = new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"),
                            WorkspaceId = new Guid("2af8941b-ba86-4fff-9063-ad77493ba820"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"),
                            WorkspaceId = new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"),
                            WorkspaceId = new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"),
                            WorkspaceId = new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"),
                            Role = 2
                        },
                        new
                        {
                            UserId = new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"),
                            WorkspaceId = new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"),
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
                            Id = new Guid("fbb37d69-3ffa-4279-8f8e-e69c7ed0d7a2"),
                            Name = "Marketing",
                            OwnerId = new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5")
                        },
                        new
                        {
                            Id = new Guid("ef9e7cc6-4e0a-4f72-9da2-1498c63b32a9"),
                            Name = "Development",
                            OwnerId = new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5")
                        },
                        new
                        {
                            Id = new Guid("2af8941b-ba86-4fff-9063-ad77493ba820"),
                            Name = "Design",
                            OwnerId = new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6")
                        },
                        new
                        {
                            Id = new Guid("8e283f09-2057-4a72-ba7a-bef88a4a125f"),
                            Name = "Sales",
                            OwnerId = new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c")
                        },
                        new
                        {
                            Id = new Guid("2bf14e44-eab1-4dbe-b086-da90e27897fd"),
                            Name = "HR",
                            OwnerId = new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c")
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
                                    UserId = new Guid("d37860e5-a49d-40f6-9d72-f5e4566a07b5"),
                                    Value = "john.doe@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("25381b97-c3a3-43e2-8024-714e2c54ebd5"),
                                    Value = "jane.smith@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("f5658c57-f191-451c-81fc-b4b76adfadf6"),
                                    Value = "michael.johnson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("90eee8d0-f956-4b6c-9f7c-e1ecd5b56f8c"),
                                    Value = "emily.davis@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("8aa54f86-c7d7-45f8-b85c-f1baf9e35c5c"),
                                    Value = "chris.brown@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("ac22d790-84bb-4c98-91e4-f8ca8a3c1cbf"),
                                    Value = "sophia.wilson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("c3c7fb61-aa85-4c5b-bf7a-b5a1b87a55eb"),
                                    Value = "daniel.martinez@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("3f30dd69-54e4-4331-839d-088044a173ba"),
                                    Value = "olivia.garcia@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("9cbb6de2-eda2-4770-9e93-bd4179aec0ac"),
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
