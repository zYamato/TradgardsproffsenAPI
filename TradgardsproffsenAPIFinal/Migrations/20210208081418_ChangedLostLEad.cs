using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class ChangedLostLEad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LeadJobb_JobId",
                table: "LeadJobb",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_Job_JobId",
                table: "LeadJobb",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_Job_JobId",
                table: "LeadJobb");

            migrationBuilder.DropIndex(
                name: "IX_LeadJobb_JobId",
                table: "LeadJobb");
        }
    }
}
