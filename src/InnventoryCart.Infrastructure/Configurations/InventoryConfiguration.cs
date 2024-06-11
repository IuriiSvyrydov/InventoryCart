using InventoryCart.Domain.Inventories;
using InventoryCart.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryCart.Infrastructure.Configurations
{
    public sealed class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {

        public InventoryConfiguration()
        {
        }
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("inventories");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Location).HasMaxLength(200)
            .HasConversion(x=>x.Value,value=>new Location(value));
            builder.OwnsOne(x=>x.RecorderLevel);
            builder.OwnsOne(x=>x.Quantity);
            builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(x=>x.ProductId);
        }
    }
}
