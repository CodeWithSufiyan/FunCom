using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class edit_CustomerModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Billing_Region",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Building",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Credit_Card",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Credit_Card_Type_Id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_Region",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Billing_Person_Name",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_State",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Card_Number",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_on_Card",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_State",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Billing_Person_Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Credit_Card_Number",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name_on_Card",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_State",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Billing_Region",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Building",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Card",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Card_Type_Id",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_Region",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
