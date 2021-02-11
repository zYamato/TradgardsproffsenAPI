using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class ChangesLostLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LeadId",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "SentOutLeadId",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "ValidatedLeadId",
                table: "LostLead");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "District",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "LostLead");

            migrationBuilder.AddColumn<int>(
                name: "LeadId",
                table: "LostLead",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SentOutLeadId",
                table: "LostLead",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValidatedLeadId",
                table: "LostLead",
                type: "int",
                nullable: true);

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
    }
}
