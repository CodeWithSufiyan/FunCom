using Microsoft.EntityFrameworkCore;
using AdminPortal.Models;

namespace AdminPortal.Data
{

    public class ApplicationDbContext: DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
            {

            }
        public DbSet<ProductCategoriesModel> ProductCategories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
}
}