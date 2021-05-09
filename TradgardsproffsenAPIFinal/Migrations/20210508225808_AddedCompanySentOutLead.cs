using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class AddedCompanySentOutLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyCompletedId",
                table: "CompletedLead",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompletedLead_CompanyCompletedId",
                table: "CompletedLead",
                column: "CompanyCompletedId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedLead_Company_CompanyCompletedId",
                table: "CompletedLead",
                column: "CompanyCompletedId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedLead_Company_CompanyCompletedId",
                table: "CompletedLead");

            migrationBuilder.DropIndex(
                name: "IX_CompletedLead_CompanyCompletedId",
                table: "CompletedLead");

            migrationBuilder.DropColumn(
                name: "CompanyCompletedId",
                table: "CompletedLead");
        }
    }
}
