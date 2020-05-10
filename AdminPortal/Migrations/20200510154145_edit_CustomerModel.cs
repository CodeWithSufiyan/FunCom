using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class edit_CustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Address1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_PostalCode",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billing_Region",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Building",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Card_Exp_Month",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Card_Exp_Year",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Card",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Credit_Card_Type_Id",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date_Entered",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_Number",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postal_Code",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_PostalCode",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shipping_Region",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voice_Mail",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_PostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Billing_Region",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Building",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Card_Exp_Month",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Card_Exp_Year",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Credit_Card",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Credit_Card_Type_Id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Date_Entered",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone_Number",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postal_Code",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_PostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Shipping_Region",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Voice_Mail",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer_name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date_of_birth",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
