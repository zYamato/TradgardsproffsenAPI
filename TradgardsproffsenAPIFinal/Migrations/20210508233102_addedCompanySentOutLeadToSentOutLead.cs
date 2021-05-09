using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class addedCompanySentOutLeadToSentOutLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySentOutLead_Company_CompaniesSentToId",
                table: "CompanySentOutLead");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySentOutLead_SentOutLead_LeadsId",
                table: "CompanySentOutLead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanySentOutLead",
                table: "CompanySentOutLead");

            migrationBuilder.RenameColumn(
                name: "LeadsId",
                table: "CompanySentOutLead",
                newName: "SentOutLeadId");

            migrationBuilder.RenameColumn(
                name: "CompaniesSentToId",
                table: "CompanySentOutLead",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanySentOutLead_LeadsId",
                table: "CompanySentOutLead",
                newName: "IX_CompanySentOutLead_SentOutLeadId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "SentOutLead",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CompanySentOutLead",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanySentOutLead",
                table: "CompanySentOutLead",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SentOutLead_CompanyId",
                table: "SentOutLead",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySentOutLead_SentOutLead_SentOutLeadId",
                table: "CompanySentOutLead",
                column: "SentOutLeadId",
                principalTable: "SentOutLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentOutLead_Company_CompanyId",
                table: "SentOutLead",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySentOutLead_SentOutLead_SentOutLeadId",
                table: "CompanySentOutLead");

            migrationBuilder.DropForeignKey(
                name: "FK_SentOutLead_Company_CompanyId",
                table: "SentOutLead");

            migrationBuilder.DropIndex(
                name: "IX_SentOutLead_CompanyId",
                table: "SentOutLead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanySentOutLead",
                table: "CompanySentOutLead");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "SentOutLead");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CompanySentOutLead");

            migrationBuilder.RenameColumn(
                name: "SentOutLeadId",
                table: "CompanySentOutLead",
                newName: "LeadsId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanySentOutLead",
                newName: "CompaniesSentToId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanySentOutLead_SentOutLeadId",
                table: "CompanySentOutLead",
                newName: "IX_CompanySentOutLead_LeadsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanySentOutLead",
                table: "CompanySentOutLead",
                columns: new[] { "CompaniesSentToId", "LeadsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySentOutLead_Company_CompaniesSentToId",
                table: "CompanySentOutLead",
                column: "CompaniesSentToId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySentOutLead_SentOutLead_LeadsId",
                table: "CompanySentOutLead",
                column: "LeadsId",
                principalTable: "SentOutLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
