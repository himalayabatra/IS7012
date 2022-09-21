using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatBatraha.Migrations
{
    public partial class Candidate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AverageSalary",
                table: "Industry",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryID",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryID",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobtitleId",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryID",
                table: "Company",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IndustryID",
                table: "Candidate",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_JobtitleId",
                table: "Candidate",
                column: "JobtitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryID",
                table: "Candidate",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "IndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Jobtitle_JobtitleId",
                table: "Candidate",
                column: "JobtitleId",
                principalTable: "Jobtitle",
                principalColumn: "jobtitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryID",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Jobtitle_JobtitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_IndustryID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_IndustryID",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_JobtitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "AverageSalary",
                table: "Industry");

            migrationBuilder.DropColumn(
                name: "IndustryID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IndustryID",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobtitleId",
                table: "Candidate");
        }
    }
}
