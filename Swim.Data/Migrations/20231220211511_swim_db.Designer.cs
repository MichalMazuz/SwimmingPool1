﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Swim.Data;

#nullable disable

namespace Swim.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231220211511_swim_db")]
    partial class swim_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Swim.Core.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<string>("LessonDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LessonHour")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.ToTable("lessons");
                });

            modelBuilder.Entity("Swim.Core.Entities.Presence", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.HasKey("TeacherId", "StudentId", "LessonId");

                    b.ToTable("presences");
                });

            modelBuilder.Entity("Swim.Core.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentsPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StudentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("StudentStatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Swim.Core.Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("TeacherAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherDays")
                        .HasColumnType("int");

                    b.Property<string>("TeacherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TeacherHour")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeacherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TeacherStatus")
                        .HasColumnType("bit");

                    b.HasKey("TeacherId");

                    b.ToTable("teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
