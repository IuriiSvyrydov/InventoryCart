using InventoryCart.Domain.Categories;
using InventoryCart.Domain.Inventories;
using InventoryCart.Domain.Orders;
using InventoryCart.Domain.Products;
using Microsoft.EntityFrameworkCore;



namespace InventoryCart.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> GetOrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
