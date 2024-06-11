using InventoryCart.Domain.Abstractions;


namespace InventoryCart.Domain.Products.Events
{
    public record CreateProductDomainEvent(Guid productId): IDomainEvent;
    
}
