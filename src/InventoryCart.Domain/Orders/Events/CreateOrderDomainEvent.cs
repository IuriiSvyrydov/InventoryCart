
using InventoryCart.Domain.Abstractions;

namespace InventoryCart.Domain.Orders.Events
{
    public record CreateOrderDomainEvent(Guid orderId): IDomainEvent;
    
}
