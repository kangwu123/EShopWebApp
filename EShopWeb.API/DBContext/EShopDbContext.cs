using EShopWeb.API.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShopWeb.API.DBContext
{
    public class EShopDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration by Fluent API

            //Identity Default Table

            // Add Record Data

        }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductsMedia> ProductsMedia { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ProductCategory> ProductInCategories { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
    }
}
