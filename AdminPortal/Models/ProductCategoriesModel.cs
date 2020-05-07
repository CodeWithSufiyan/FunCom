using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPortal.Models
{
    public class ProductCategoriesModel
    {
        public ProductCategoriesModel()
        {
            Products = new HashSet<ProductModel>();
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
    
        // --------------CREATES A SQL FOREIGN KEY RELATION WITH CATEGORYMODEL
        // --------------PRODUCTS -> CHILD
        // 1 Category has multiple Products(childs)
        public virtual ICollection<ProductModel> Products { get; set; }
        // ------------------------------------
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Active { get; set; }
    }
}
