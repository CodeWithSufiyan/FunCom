using System;

namespace AdminPortal.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public long ProductCategoryFk { get; set; }
        public string Name { get; set; }

    
    }
}
