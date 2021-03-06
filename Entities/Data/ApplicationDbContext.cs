using Microsoft.EntityFrameworkCore;
using Entities.DB;

namespace Application.Data
{

    public class ApplicationDbContext: DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
            {

            }
        public DbSet<ProductCategoriesModel> ProductCategories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<SocialMediaModel> SocialMedia { get; set; }
    }
}