using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class addedStuffToLostLeadAgain2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LostLead_LeadId",
                table: "LostLead",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LostLead_SentOutLeadId",
                table: "LostLead",
                column: "SentOutLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LostLead_ValidatedLeadId",
                table: "LostLead",
                column: "ValidatedLeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_LostLead_Lead_LeadId",
                table: "LostLead",
                column: "LeadId",
                principalTable: "Lead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LostLead_SentOutLead_SentOutLeadId",
                table: "LostLead",
                column: "SentOutLeadId",
                principalTable: "SentOutLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LostLead_ValidatedLead_ValidatedLeadId",
                table: "LostLead",
                column: "ValidatedLeadId",
                principalTable: "ValidatedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LostLead_Lead_LeadId",
                table: "LostLead");

            migrationBuilder.DropForeignKey(
                name: "FK_LostLead_SentOutLead_SentOutLeadId",
                table: "LostLead");

            migrationBuilder.DropForeignKey(
                name: "FK_LostLead_ValidatedLead_ValidatedLeadId",
                table: "LostLead");

            migrationBuilder.DropIndex(
                name: "IX_LostLead_LeadId",
                table: "LostLead");

            migrationBuilder.DropIndex(
                name: "IX_LostLead_SentOutLeadId",
                table: "LostLead");

            migrationBuilder.DropIndex(
                name: "IX_LostLead_ValidatedLeadId",
                table: "LostLead");
        }
    }
}
