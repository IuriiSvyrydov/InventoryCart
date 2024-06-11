
using InventoryCart.Domain.Abstractions;

namespace InventoryCart.Domain.Categories.Events
{
    public record CreateCategoryDomainEvent(Guid inventoryId): IDomainEvent;
    
}
