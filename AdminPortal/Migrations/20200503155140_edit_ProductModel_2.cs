using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class edit_ProductModel_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryFk",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Available_Colors",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Availale_Size",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Colors",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Current_Order",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Discount_Available",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSKU",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MSRP",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_Available",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity_Per_Unit",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ranking",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reorder_Level",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Unit_Price",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Unit_Weight",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Units_On_Order",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Units_in_Stock",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Vendor_ProductID",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available_Colors",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Availale_Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Colors",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Current_Order",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount_Available",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdSKU",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MSRP",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Available",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity_Per_Unit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Reorder_Level",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Unit_Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Unit_Weight",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Units_On_Order",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Units_in_Stock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Vendor_ProductID",
                table: "Products");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Products",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductCategoryFk",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
