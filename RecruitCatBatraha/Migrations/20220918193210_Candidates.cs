using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatBatraha.Migrations
{
    public partial class Candidates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetSalary = table.Column<double>(type: "float", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    experience = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    skills = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.CandidateId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    positionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minimumSalary = table.Column<double>(type: "float", nullable: false),
                    maximumSalary = table.Column<double>(type: "float", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isFortune500 = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryDomain = table.Column<int>(type: "int", nullable: true),
                    IndustryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.IndustryId);
                });

            migrationBuilder.CreateTable(
                name: "Jobtitle",
                columns: table => new
                {
                    jobtitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minimumSalary = table.Column<double>(type: "float", nullable: false),
                    maximumSalary = table.Column<double>(type: "float", nullable: false),
                    jobOpenings = table.Column<int>(type: "int", nullable: true),
                    requiredSkills = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobtitle", x => x.jobtitleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "Jobtitle");
        }
    }
}
