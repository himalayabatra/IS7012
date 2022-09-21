﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatBatraha.Data;

#nullable disable

namespace RecruitCatBatraha.Migrations
{
    [DbContext(typeof(RecruitCatBatrahaContext))]
    [Migration("20220918193551_Jobtitles")]
    partial class Jobtitles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecruitCatBatraha.Models.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateId"), 1L, 1);

                    b.Property<decimal>("experience")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("targetSalary")
                        .HasColumnType("float");

                    b.HasKey("CandidateId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<bool?>("isFortune500")
                        .HasColumnType("bit");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("maximumSalary")
                        .HasColumnType("float");

                    b.Property<double>("minimumSalary")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("positionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Industry", b =>
                {
                    b.Property<int>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndustryId"), 1L, 1);

                    b.Property<string>("IndustryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IndustryDomain")
                        .HasColumnType("int");

                    b.Property<string>("IndustryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IndustryId");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Jobtitle", b =>
                {
                    b.Property<int>("jobtitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("jobtitleId"), 1L, 1);

                    b.Property<int?>("jobOpenings")
                        .HasColumnType("int");

                    b.Property<double>("maximumSalary")
                        .HasColumnType("float");

                    b.Property<double>("minimumSalary")
                        .HasColumnType("float");

                    b.Property<string>("requiredSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jobtitleId");

                    b.ToTable("Jobtitle");
                });
#pragma warning restore 612, 618
        }
    }
}
