﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using W25W12CodeFirstApproach;

#nullable disable

namespace W25W12CodeFirstApproach.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20250402203758_ChangeColumnStudentNameToName")]
    partial class ChangeColumnStudentNameToName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("W25W12CodeFirstApproach.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StandardId"));

                    b.Property<string>("StandardName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");

                    b.HasData(
                        new
                        {
                            StandardId = 1,
                            StandardName = "Standard 1"
                        },
                        new
                        {
                            StandardId = 2,
                            StandardName = "Standard 2"
                        },
                        new
                        {
                            StandardId = 3,
                            StandardName = "Standard 3"
                        });
                });

            modelBuilder.Entity("W25W12CodeFirstApproach.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("StandardId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("StudentId");

                    b.HasIndex("StandardId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StandardId = 1,
                            StudentName = "John"
                        },
                        new
                        {
                            StudentId = 2,
                            StandardId = 1,
                            StudentName = "Anne"
                        },
                        new
                        {
                            StudentId = 3,
                            StandardId = 2,
                            StudentName = "Mark"
                        },
                        new
                        {
                            StudentId = 4,
                            StandardId = 3,
                            StudentName = "Tina"
                        });
                });

            modelBuilder.Entity("W25W12CodeFirstApproach.Student", b =>
                {
                    b.HasOne("W25W12CodeFirstApproach.Standard", "Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId");

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("W25W12CodeFirstApproach.Standard", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
