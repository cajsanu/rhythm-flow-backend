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
    [Migration("20241121221948_Initializing")]
    partial class Initializing
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

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
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
                });

            modelBuilder.Entity("RhythmFlow.Domain.src.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp with time zone")
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
