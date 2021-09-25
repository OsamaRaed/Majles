﻿// <auto-generated />
using System;
using Majles.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Majles.Data.Migrations
{
    [DbContext(typeof(MajlesDbContext))]
    partial class MajlesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Majles.Data.DbEntity.AttendenceDbEntity", b =>
                {
                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("LectureId1")
                        .HasColumnType("int");

                    b.Property<int?>("LectureMajlesId")
                        .HasColumnType("int");

                    b.HasKey("LectureId", "StudentId");

                    b.HasIndex("StudentId");

                    b.HasIndex("LectureId1", "LectureMajlesId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.AuthorBookDbEntity", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorBooks");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.AuthorDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookCategoryDbEntity", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookMajlesDbEntity", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("MajlesId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "MajlesId");

                    b.HasIndex("MajlesId");

                    b.ToTable("BookMajles");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.CategoryDbEntity", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Name");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.LectureDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("MajlesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("MosqeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "MajlesId");

                    b.HasIndex("MajlesId");

                    b.HasIndex("MosqeName");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("MosqeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SheikhId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MosqeName");

                    b.HasIndex("SheikhId");

                    b.ToTable("Majles");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesStudentDbEntity", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("MajlesId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "MajlesId");

                    b.HasIndex("MajlesId");

                    b.ToTable("MajlesStudents");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesVolunteerDbEntity", b =>
                {
                    b.Property<int>("VolunteerId")
                        .HasColumnType("int");

                    b.Property<int>("MajlesId")
                        .HasColumnType("int");

                    b.Property<string>("VolunteerUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VolunteerId", "MajlesId");

                    b.HasIndex("MajlesId");

                    b.HasIndex("VolunteerUserName");

                    b.ToTable("MajlesVolunteers");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MosqeDbEntity", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Name");

                    b.ToTable("Mosqes");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.RegionDbEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.SheikhDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sheikhs");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.SheikhPhoneDbEntity", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("SheikhId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("PhoneNumber");

                    b.HasIndex("SheikhId");

                    b.ToTable("SheikhPhones");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.StudentDbEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.StudentPhoneDbEntity", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("PhoneNumber");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentPhones");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.VolunteerDbEntity", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserName");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.VolunteerPhoneDbEntity", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("VolunteerId")
                        .HasColumnType("int");

                    b.Property<string>("VolunteerUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PhoneNumber");

                    b.HasIndex("VolunteerUserName");

                    b.ToTable("VolunteerPhones");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.AttendenceDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.StudentDbEntity", "Student")
                        .WithMany("Attendences")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.LectureDbEntity", "Lecture")
                        .WithMany("Attendences")
                        .HasForeignKey("LectureId1", "LectureMajlesId");

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.AuthorBookDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.AuthorDbEntity", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.BookDbEntity", "Book")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookCategoryDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.BookDbEntity", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.CategoryDbEntity", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookMajlesDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.BookDbEntity", "Book")
                        .WithMany("BookMajles")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.MajlesDbEntity", "Majles")
                        .WithMany("BookMajles")
                        .HasForeignKey("MajlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Majles");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.LectureDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.MajlesDbEntity", "Majles")
                        .WithMany("Lectures")
                        .HasForeignKey("MajlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.MosqeDbEntity", "Mosqe")
                        .WithMany("Lectures")
                        .HasForeignKey("MosqeName");

                    b.Navigation("Majles");

                    b.Navigation("Mosqe");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.MosqeDbEntity", "Mosqe")
                        .WithMany("Majles")
                        .HasForeignKey("MosqeName");

                    b.HasOne("Majles.Data.DbEntity.SheikhDbEntity", "Sheikh")
                        .WithMany("Majles")
                        .HasForeignKey("SheikhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mosqe");

                    b.Navigation("Sheikh");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesStudentDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.MajlesDbEntity", "Majles")
                        .WithMany("MajlesStudents")
                        .HasForeignKey("MajlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.StudentDbEntity", "Student")
                        .WithMany("MajlesStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Majles");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesVolunteerDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.MajlesDbEntity", "Majles")
                        .WithMany("MajlesVolunteers")
                        .HasForeignKey("MajlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Majles.Data.DbEntity.VolunteerDbEntity", "Volunteer")
                        .WithMany("MajlesVolunteers")
                        .HasForeignKey("VolunteerUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Majles");

                    b.Navigation("Volunteer");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.SheikhPhoneDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.SheikhDbEntity", "Sheikh")
                        .WithMany("SheikhPhones")
                        .HasForeignKey("SheikhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sheikh");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.StudentDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.RegionDbEntity", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.StudentPhoneDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.StudentDbEntity", "Student")
                        .WithMany("StudentPhones")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.VolunteerPhoneDbEntity", b =>
                {
                    b.HasOne("Majles.Data.DbEntity.VolunteerDbEntity", "Volunteer")
                        .WithMany("VolunteerPhones")
                        .HasForeignKey("VolunteerUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Volunteer");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.AuthorDbEntity", b =>
                {
                    b.Navigation("AuthorBooks");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.BookDbEntity", b =>
                {
                    b.Navigation("AuthorBooks");

                    b.Navigation("BookCategories");

                    b.Navigation("BookMajles");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.CategoryDbEntity", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.LectureDbEntity", b =>
                {
                    b.Navigation("Attendences");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MajlesDbEntity", b =>
                {
                    b.Navigation("BookMajles");

                    b.Navigation("Lectures");

                    b.Navigation("MajlesStudents");

                    b.Navigation("MajlesVolunteers");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.MosqeDbEntity", b =>
                {
                    b.Navigation("Lectures");

                    b.Navigation("Majles");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.SheikhDbEntity", b =>
                {
                    b.Navigation("Majles");

                    b.Navigation("SheikhPhones");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.StudentDbEntity", b =>
                {
                    b.Navigation("Attendences");

                    b.Navigation("MajlesStudents");

                    b.Navigation("StudentPhones");
                });

            modelBuilder.Entity("Majles.Data.DbEntity.VolunteerDbEntity", b =>
                {
                    b.Navigation("MajlesVolunteers");

                    b.Navigation("VolunteerPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
