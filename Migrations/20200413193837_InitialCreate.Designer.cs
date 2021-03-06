﻿// <auto-generated />
using System;
using DisplayProp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DisplayProp.Migrations
{
    [DbContext(typeof(DisplayPropContext))]
    [Migration("20200413193837_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DisplayProp.Models.Camper", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Campers");
                });

            modelBuilder.Entity("DisplayProp.Models.Enrollment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CamperID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CamperID");

                    b.HasIndex("GameID");

                    b.HasIndex("MealID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("DisplayProp.Models.Game", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Computer")
                        .HasColumnType("int");

                    b.Property<int>("Gym")
                        .HasColumnType("int");

                    b.Property<int>("RecRoom")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("DisplayProp.Models.Meal", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Breakfast")
                        .HasColumnType("int");

                    b.Property<int>("Lunch")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("DisplayProp.Models.Enrollment", b =>
                {
                    b.HasOne("DisplayProp.Models.Camper", "Camper")
                        .WithMany("Enrollments")
                        .HasForeignKey("CamperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DisplayProp.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DisplayProp.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
