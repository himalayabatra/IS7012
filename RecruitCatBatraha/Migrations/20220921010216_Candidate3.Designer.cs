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
    [Migration("20220921010216_Candidate3")]
    partial class Candidate3
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

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("IndustryID")
                        .HasColumnType("int");

                    b.Property<int?>("JobtitleId")
                        .HasColumnType("int");

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

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryID");

                    b.HasIndex("JobtitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<int?>("IndustryID")
                        .HasColumnType("int");

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

                    b.HasIndex("IndustryID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Industry", b =>
                {
                    b.Property<int>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndustryId"), 1L, 1);

                    b.Property<decimal?>("AverageSalary")
                        .HasColumnType("decimal(18,2)");

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

            modelBuilder.Entity("RecruitCatBatraha.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatBatraha.Models.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId");

                    b.HasOne("RecruitCatBatraha.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryID");

                    b.HasOne("RecruitCatBatraha.Models.Jobtitle", "Jobtitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobtitleId");

                    b.Navigation("Company");

                    b.Navigation("Industry");

                    b.Navigation("Jobtitle");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Company", b =>
                {
                    b.HasOne("RecruitCatBatraha.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryID");

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Company", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Industry", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("RecruitCatBatraha.Models.Jobtitle", b =>
                {
                    b.Navigation("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
