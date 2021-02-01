using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class madeValidatedLeadNullable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb");

            migrationBuilder.AlterColumn<int>(
                name: "ValidatedLeadId",
                table: "LeadJobb",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb",
                column: "ValidatedLeadId",
                principalTable: "ValidatedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb");

            migrationBuilder.AlterColumn<int>(
                name: "ValidatedLeadId",
                table: "LeadJobb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJobb_ValidatedLead_ValidatedLeadId",
                table: "LeadJobb",
                column: "ValidatedLeadId",
                principalTable: "ValidatedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
