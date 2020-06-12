using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class edit_SocialMediaModel_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "SocialMedia",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SocialMedia",
                newName: "status");
        }
    }
}
