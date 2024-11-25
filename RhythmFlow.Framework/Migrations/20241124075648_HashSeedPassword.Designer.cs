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
    [Migration("20241124075648_HashSeedPassword")]
    partial class HashSeedPassword
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
                            Id = new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"),
                            Description = "Conquer the Galaxy",
                            EndDate = new DateOnly(2025, 1, 13),
                            Name = "Alpha",
                            StartDate = new DateOnly(2024, 11, 26),
                            Status = "InProgress",
                            WorkspaceId = new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d")
                        },
                        new
                        {
                            Id = new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"),
                            Description = "Develop AI Assistant",
                            EndDate = new DateOnly(2025, 1, 23),
                            Name = "Beta",
                            StartDate = new DateOnly(2024, 11, 29),
                            Status = "NotStarted",
                            WorkspaceId = new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6")
                        },
                        new
                        {
                            Id = new Guid("b7cd139c-f87b-417f-8a39-24732f7146c9"),
                            Description = "Revamp Website Design",
                            EndDate = new DateOnly(2025, 1, 8),
                            Name = "Gamma",
                            StartDate = new DateOnly(2024, 11, 27),
                            Status = "InProgress",
                            WorkspaceId = new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d")
                        },
                        new
                        {
                            Id = new Guid("e860e23e-3616-4e8d-b517-8e62e92740b6"),
                            Description = "Launch Mobile App",
                            EndDate = new DateOnly(2025, 2, 22),
                            Name = "Delta",
                            StartDate = new DateOnly(2024, 12, 1),
                            Status = "InProgress",
                            WorkspaceId = new Guid("1d2128f7-fc01-44c9-b221-1079a6b5594e")
                        },
                        new
                        {
                            Id = new Guid("0dad8c65-ce0f-4429-8aff-977b02f7daed"),
                            Description = "Implement Cloud Migration",
                            EndDate = new DateOnly(2025, 3, 24),
                            Name = "Epsilon",
                            StartDate = new DateOnly(2024, 11, 25),
                            Status = "Cancelled",
                            WorkspaceId = new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d")
                        },
                        new
                        {
                            Id = new Guid("a0b80cae-e906-4c2b-813b-9b922e633b5d"),
                            Description = "Optimize Data Pipeline",
                            EndDate = new DateOnly(2025, 2, 12),
                            Name = "Zeta",
                            StartDate = new DateOnly(2024, 12, 4),
                            Status = "InProgress",
                            WorkspaceId = new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d")
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
                            Id = new Guid("5c239a93-75f1-4dd8-a969-6d06cf78fe6a"),
                            Deadline = new DateOnly(2024, 12, 1),
                            Description = "using Postgres",
                            Priority = "High",
                            ProjectId = new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"),
                            Status = "InProgress",
                            Title = "Create Database",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d92858fd-f52a-466c-aab8-c672bff78f23"),
                            Deadline = new DateOnly(2024, 11, 27),
                            Description = "Resolve authentication error",
                            Priority = "High",
                            ProjectId = new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"),
                            Status = "InProgress",
                            Title = "Fix Login Issue",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("0fbeb34e-0e33-4658-ab7e-e2e88c24ae63"),
                            Deadline = new DateOnly(2024, 12, 8),
                            Description = "Create wireframe for new landing page",
                            Priority = "Medium",
                            ProjectId = new Guid("9415b953-610a-4f76-8a2a-08ae9f8bc814"),
                            Status = "Cancelled",
                            Title = "Design Landing Page",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("5a2e061c-4bc4-4350-9e21-83326ca4abe3"),
                            Deadline = new DateOnly(2024, 12, 24),
                            Description = "Review and update policy document",
                            Priority = "Low",
                            ProjectId = new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"),
                            Status = "NotStarted",
                            Title = "Update Privacy Policy",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("5d11edda-9957-44c7-a32b-51b2f1a7de0a"),
                            Deadline = new DateOnly(2024, 12, 4),
                            Description = "Enhance performance of existing API calls",
                            Priority = "High",
                            ProjectId = new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"),
                            Status = "InProgress",
                            Title = "Optimize API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("521f0ab4-8a2e-4fed-98e7-ef1a681dbaa5"),
                            Deadline = new DateOnly(2024, 12, 1),
                            Description = "Plan onboarding session for new hires",
                            Priority = "Medium",
                            ProjectId = new Guid("aa64b7a2-e9b9-4c25-b87a-62c6d764f5ac"),
                            Status = "NotStarted",
                            Title = "Schedule Training",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("fb69de22-22fa-4117-a74b-139fcf017106"),
                            Deadline = new DateOnly(2024, 12, 15),
                            Description = "Implement dark mode toggle for Users",
                            Priority = "High",
                            ProjectId = new Guid("0dad8c65-ce0f-4429-8aff-977b02f7daed"),
                            Status = "Cancelled",
                            Title = "Add Dark Mode",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a72df026-d893-469d-b625-5206c131bf30"),
                            Deadline = new DateOnly(2024, 11, 29),
                            Description = "Fix issue with incorrect data rendering",
                            Priority = "High",
                            ProjectId = new Guid("a0b80cae-e906-4c2b-813b-9b922e633b5d"),
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
                            Id = new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"),
                            FirstName = "John",
                            LastName = "Doe",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"),
                            FirstName = "Jane",
                            LastName = "Smith",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"),
                            FirstName = "Michael",
                            LastName = "Johnson",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"),
                            FirstName = "Emily",
                            LastName = "Davis",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57"),
                            FirstName = "Chris",
                            LastName = "Brown",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"),
                            FirstName = "Sophia",
                            LastName = "Wilson",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"),
                            FirstName = "Daniel",
                            LastName = "Martinez",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("d2bf611c-f2d9-47f0-a9d6-1c7703a4becf"),
                            FirstName = "Olivia",
                            LastName = "Garcia",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
                        },
                        new
                        {
                            Id = new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"),
                            FirstName = "Matthew",
                            LastName = "Anderson",
                            PasswordHash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi"
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
                            UserId = new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"),
                            WorkspaceId = new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"),
                            WorkspaceId = new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"),
                            WorkspaceId = new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"),
                            WorkspaceId = new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"),
                            WorkspaceId = new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"),
                            Role = 1
                        },
                        new
                        {
                            UserId = new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"),
                            WorkspaceId = new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"),
                            Role = 2
                        },
                        new
                        {
                            UserId = new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"),
                            WorkspaceId = new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"),
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
                            Id = new Guid("3b2630f5-17f6-4f41-84aa-c6eced59bd2d"),
                            Name = "Marketing",
                            OwnerId = new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8")
                        },
                        new
                        {
                            Id = new Guid("0b8dac96-9f38-4328-a594-48aad8f6cff6"),
                            Name = "Development",
                            OwnerId = new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a")
                        },
                        new
                        {
                            Id = new Guid("f4a7a744-e967-4997-8163-fb5e7915cb6d"),
                            Name = "Design",
                            OwnerId = new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c")
                        },
                        new
                        {
                            Id = new Guid("1d2128f7-fc01-44c9-b221-1079a6b5594e"),
                            Name = "Sales",
                            OwnerId = new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16")
                        },
                        new
                        {
                            Id = new Guid("53a2beea-6ece-4a0c-8852-3fdaf4608f2d"),
                            Name = "HR",
                            OwnerId = new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57")
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
                                    UserId = new Guid("38c55e68-9178-4ba3-89c1-c0a7fb6effa8"),
                                    Value = "john.doe@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("93ab30e4-b10f-45b2-b307-691e46e8c46a"),
                                    Value = "jane.smith@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("5185f6db-d2a0-4d3f-83a7-fa898baad42c"),
                                    Value = "michael.johnson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("bd9239b0-e2a2-4781-812f-f236859f2f16"),
                                    Value = "emily.davis@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("f7a28a2d-a6a9-4ed8-9f85-d718f1198f57"),
                                    Value = "chris.brown@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("b1e6173f-5119-47c9-bec6-9f807eba4cdd"),
                                    Value = "sophia.wilson@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("b51eeff7-77c3-4687-8679-07ab0830e31f"),
                                    Value = "daniel.martinez@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("d2bf611c-f2d9-47f0-a9d6-1c7703a4becf"),
                                    Value = "olivia.garcia@example.com"
                                },
                                new
                                {
                                    UserId = new Guid("ac0fdb85-81c1-4c32-b5e2-aeef5c4d1c2f"),
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
