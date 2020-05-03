using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_name = table.Column<string>(nullable: true),
                    Date_of_birth = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<long>(nullable: false),
                    SKU = table.Column<string>(nullable: true),
                    IdSKU = table.Column<int>(nullable: false),
                    Vendor_ProductID = table.Column<string>(nullable: true),
                    Product_Name = table.Column<string>(nullable: true),
                    Product_Description = table.Column<string>(nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    Quantity_Per_Unit = table.Column<int>(nullable: false),
                    Unit_Price = table.Column<int>(nullable: false),
                    MSRP = table.Column<int>(nullable: false),
                    Availale_Size = table.Column<string>(nullable: true),
                    Available_Colors = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Colors = table.Column<string>(nullable: true),
                    Discount = table.Column<int>(nullable: false),
                    Unit_Weight = table.Column<int>(nullable: false),
                    Units_in_Stock = table.Column<int>(nullable: false),
                    Units_On_Order = table.Column<int>(nullable: false),
                    Reorder_Level = table.Column<string>(nullable: true),
                    Product_Available = table.Column<string>(nullable: true),
                    Discount_Available = table.Column<int>(nullable: false),
                    Current_Order = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Ranking = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
