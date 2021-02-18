using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class changedNameOnLeadJobb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_Job_JobId",
                table: "LeadJobb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_SentOutLead_SentOutLeadId",
                table: "LeadJobb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadJobb",
                table: "LeadJobb");

            migrationBuilder.RenameTable(
                name: "LeadJobb",
                newName: "LeadJob");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJobb_ValidatedLeadId",
                table: "LeadJob",
                newName: "IX_LeadJob_ValidatedLeadId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJobb_SentOutLeadId",
                table: "LeadJob",
                newName: "IX_LeadJob_SentOutLeadId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJobb_JobId",
                table: "LeadJob",
                newName: "IX_LeadJob_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadJob",
                table: "LeadJob",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJob_Job_JobId",
                table: "LeadJob",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJob_SentOutLead_SentOutLeadId",
                table: "LeadJob",
                column: "SentOutLeadId",
                principalTable: "SentOutLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJob_ValidatedLead_ValidatedLeadId",
                table: "LeadJob",
                column: "ValidatedLeadId",
                principalTable: "ValidatedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadJob_Job_JobId",
                table: "LeadJob");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadJob_SentOutLead_SentOutLeadId",
                table: "LeadJob");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadJob_ValidatedLead_ValidatedLeadId",
                table: "LeadJob");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadJob",
                table: "LeadJob");

            migrationBuilder.RenameTable(
                name: "LeadJob",
                newName: "LeadJobb");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJob_ValidatedLeadId",
                table: "LeadJobb",
                newName: "IX_LeadJobb_ValidatedLeadId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJob_SentOutLeadId",
                table: "LeadJobb",
                newName: "IX_LeadJobb_SentOutLeadId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadJob_JobId",
                table: "LeadJobb",
                newName: "IX_LeadJobb_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadJobb",
                table: "LeadJobb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_Job_JobId",
                table: "LeadJobb",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_SentOutLead_SentOutLeadId",
                table: "LeadJobb",
                column: "SentOutLeadId",
                principalTable: "SentOutLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb",
                column: "ValidatedLeadId",
                principalTable: "ValidatedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
