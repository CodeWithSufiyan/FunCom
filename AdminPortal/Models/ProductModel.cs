using System;

using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPortal.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        // --------------CREATES A SQL FOREIGN KEY RELATION WITH CATEGORYMODEL
        // --------------PRODUCTCATEGORY -> PARENT 
        // 1 Product has 1 Category only
        [ForeignKey("Category")]
        public long CategoryID { get; set; }
        public virtual ProductCategoriesModel Category{get;set;}
        // ---------------------------------------------------

        public string SKU { get; set; }
        public int IdSKU { get; set; }
        public string Vendor_ProductID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int SupplierID { get; set; }
        public int Quantity_Per_Unit { get; set; }
        public int Unit_Price { get; set; }
        public int MSRP { get; set; }
        public string Availale_Size { get; set; }
        public string Available_Colors { get; set; }
        public string Size { get; set; }
        public string Colors { get; set; }
        public int Discount { get; set; }
        public int Unit_Weight { get; set; }
        public int Units_in_Stock { get; set; }
        public int Units_On_Order { get; set; }
        public string Reorder_Level { get; set; }
        public string Product_Available { get; set; }
        public int Discount_Available { get; set; }
        public string Current_Order { get; set; }
        public string Picture { get; set; }
        public string Ranking { get; set; }
        public string Note { get; set; }

    
    }
}
