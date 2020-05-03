using System;

using System.Collections.Generic;

namespace AdminPortal.Models
{
    public class ProductCategoriesModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    
        // --------------CREATES A SQL FOREIGN KEY RELATION WITH CATEGORYMODEL
        // --------------PRODUCTS -> CHILD
        // 1 Category has multiple Products(childs)
        public virtual ICollection<ProductModel> Products { get; set; }
        // ------------------------------------
    }
}
