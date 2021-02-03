using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class addedStuffToLostLeadAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "SentOut",
                table: "LostLead");

            migrationBuilder.DropColumn(
                name: "Validated",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                nullable: true);

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
                name: "Name",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "LostLead",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SentOut",
                table: "LostLead",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Validated",
                table: "LostLead",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
