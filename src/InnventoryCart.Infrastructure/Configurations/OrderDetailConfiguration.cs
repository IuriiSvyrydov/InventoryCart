

using InventoryCart.Domain.Orders;
using InventoryCart.Domain.Products.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryCart.Infrastructure.Configurations
{
    public sealed class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("orderDetails");
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.TotalPrice, builder =>
            {
                builder.Property(x => x.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
            });
        }
    }


}
