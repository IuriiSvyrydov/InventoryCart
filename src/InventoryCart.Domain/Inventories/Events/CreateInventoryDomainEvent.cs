using InventoryCart.Domain.Abstractions;


namespace InventoryCart.Domain.Inventories.Events
{
    public record CreateInventoryDomainEvent(Guid inventoryId): IDomainEvent;
    
}
