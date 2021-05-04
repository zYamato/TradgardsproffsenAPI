using Microsoft.EntityFrameworkCore.Migrations;

namespace TradgardsproffsenAPI.Migrations
{
    public partial class addedCompletedLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompletedLeadId",
                table: "LeadJob",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompletedLeadId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompletedLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedLead", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadJob_CompletedLeadId",
                table: "LeadJob",
                column: "CompletedLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompletedLeadId",
                table: "Company",
                column: "CompletedLeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_CompletedLead_CompletedLeadId",
                table: "Company",
                column: "CompletedLeadId",
                principalTable: "CompletedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadJob_CompletedLead_CompletedLeadId",
                table: "LeadJob",
                column: "CompletedLeadId",
                principalTable: "CompletedLead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompletedLead_CompletedLeadId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadJob_CompletedLead_CompletedLeadId",
                table: "LeadJob");

            migrationBuilder.DropTable(
                name: "CompletedLead");

            migrationBuilder.DropIndex(
                name: "IX_LeadJob_CompletedLeadId",
                table: "LeadJob");

            migrationBuilder.DropIndex(
                name: "IX_Company_CompletedLeadId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompletedLeadId",
                table: "LeadJob");

            migrationBuilder.DropColumn(
                name: "CompletedLeadId",
                table: "Company");
        }
    }
}
