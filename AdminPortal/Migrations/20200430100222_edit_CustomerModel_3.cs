using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class edit_CustomerModel_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approval_Required",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Conditions_Allowed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer_name",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date_of_birth",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Customer_name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Date_of_birth",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Approval_Required",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Conditions_Allowed",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
