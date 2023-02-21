﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Models;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(ETContext))]
    partial class ETContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Models.Timer", b =>
                {
                    b.Property<int>("TimerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExerciseTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RestTime")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TimerId");

                    b.HasIndex("UserId");

                    b.ToTable("Timers");
                });

            modelBuilder.Entity("Server.Models.TimerState", b =>
                {
                    b.Property<int>("TimerStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CurrentTime")
                        .HasColumnType("int");

                    b.Property<bool>("InProgress")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("SetsCompleted")
                        .HasColumnType("int");

                    b.Property<int>("TimerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("TimerStateId");

                    b.HasIndex("TimerId")
                        .IsUnique();

                    b.ToTable("TimerStates");
                });

            modelBuilder.Entity("Server.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Server.Models.Timer", b =>
                {
                    b.HasOne("Server.Models.User", null)
                        .WithMany("AllTimers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Server.Models.TimerState", b =>
                {
                    b.HasOne("Server.Models.Timer", "Timer")
                        .WithOne("TimerState")
                        .HasForeignKey("Server.Models.TimerState", "TimerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Timer");
                });

            modelBuilder.Entity("Server.Models.Timer", b =>
                {
                    b.Navigation("TimerState")
                        .IsRequired();
                });

            modelBuilder.Entity("Server.Models.User", b =>
                {
                    b.Navigation("AllTimers");
                });
#pragma warning restore 612, 618
        }
    }
}