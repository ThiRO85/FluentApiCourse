﻿// <auto-generated />
using System;
using FluentApiCourse.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiCourse.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210909200224_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiCourse.Entities.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Courses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Course");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Administrator")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.Details", b =>
                {
                    b.Property<int>("DetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("DetailsID");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OnlineCourseCourseID")
                        .HasColumnType("int");

                    b.Property<int?>("OnsiteCourseCourseID")
                        .HasColumnType("int");

                    b.HasKey("InstructorID");

                    b.HasIndex("OnlineCourseCourseID");

                    b.HasIndex("OnsiteCourseCourseID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.OfficeAsignment", b =>
                {
                    b.Property<int>("OfficeAsignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OfficeAsignmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("OfficeAsignments");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.OnlineCourse", b =>
                {
                    b.HasBaseType("FluentApiCourse.Entities.Course");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("OnlineCourse");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.OnsiteCourse", b =>
                {
                    b.HasBaseType("FluentApiCourse.Entities.Course");

                    b.Property<int?>("DetailsID")
                        .HasColumnType("int");

                    b.HasIndex("DetailsID");

                    b.HasDiscriminator().HasValue("OnsiteCourse");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.Course", b =>
                {
                    b.HasOne("FluentApiCourse.Entities.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FluentApiCourse.Entities.Instructor", b =>
                {
                    b.HasOne("FluentApiCourse.Entities.OnlineCourse", null)
                        .WithMany("Instructors")
                        .HasForeignKey("OnlineCourseCourseID");

                    b.HasOne("FluentApiCourse.Entities.OnsiteCourse", null)
                        .WithMany("Instructors")
                        .HasForeignKey("OnsiteCourseCourseID");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.OfficeAsignment", b =>
                {
                    b.HasOne("FluentApiCourse.Entities.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorID");
                });

            modelBuilder.Entity("FluentApiCourse.Entities.OnsiteCourse", b =>
                {
                    b.HasOne("FluentApiCourse.Entities.Details", "Details")
                        .WithMany()
                        .HasForeignKey("DetailsID");
                });
#pragma warning restore 612, 618
        }
    }
}
