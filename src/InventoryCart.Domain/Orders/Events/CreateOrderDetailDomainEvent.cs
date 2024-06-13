
using InventoryCart.Domain.Abstractions;

namespace InventoryCart.Domain.Orders.Events
{
   public record CreateOrderDetailDomainEvent(Guid orderDetailId): IDomainEvent;
    
}
