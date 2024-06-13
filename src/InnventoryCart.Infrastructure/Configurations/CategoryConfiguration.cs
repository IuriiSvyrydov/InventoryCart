using InventoryCart.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryCart.Infrastructure.Configurations
{
    public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("inventories");
            builder.HasKey(c => c.Id);
            builder.Property(x => x.Name).HasConversion(x => x.Value, value => new Name(value));
            builder.Property(x => x.Description).HasMaxLength(500)
                .HasConversion(x => x.Value, value => new Description(value));
        }
    }
}
