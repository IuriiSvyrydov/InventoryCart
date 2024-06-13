

using InventoryCart.Domain.Products;
using InventoryCart.Domain.Products.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryCart.Infrastructure.Configurations;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasConversion(x => x.Value, value => new Name(value));
        builder.Property(x => x.Description)
            .HasConversion(x => x.Value, value => new Description(value));
        builder.OwnsOne(x => x.UnitPrice, builder =>
        {
            builder.Property(x => x.Currency)
            .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
        });
        builder.OwnsOne(x => x.TaxCost, builder =>
        {
            builder.Property(x => x.Currency)
            .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
        });
        builder.OwnsOne(x => x.ProfitPerUnit, builder =>
        {
            builder.Property(x => x.Currency)
            .HasConversion(x => x.Code, code => Currency.FromCode(code));
        });
        builder.OwnsOne(x => x.ProductionCost, builder =>
        {
            builder.Property(x => x.Currency)
            .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
        });
        builder.OwnsOne(x => x.ProfitPerUnit, builder =>
        {
            builder.Property(x => x.Currency)
            .HasConversion(x => x.Code, code => Currency.FromCode(code));
        });

    }
}

