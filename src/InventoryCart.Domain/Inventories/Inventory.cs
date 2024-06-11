using InventoryCart.Domain.Abstractions;
using InventoryCart.Domain.Inventories.Events;
using InventoryCart.Domain.Products;

namespace InventoryCart.Domain.Inventories;

public sealed class Inventory: Entity
{
    public Quantity Quantity { get; private set; }
    public RecorderLevel RecorderLevel { get; private set; }
    public Location Location { get; private set; }
    public DateTimeOffset? LastUpdated { get; private set; }
    public Guid ProductId { get; private set; }
    public List<Product> Products { get; private set; } = new();


    private Inventory()
    {
    
    }

    public Inventory(Guid id, 
        Guid productId,
        Quantity quantity,
        RecorderLevel recorderLevel,
        Location location,
        DateTimeOffset lastUpdated,
        List<Product>products):base(id)
    {
        ProductId = productId;
        Quantity = quantity;
        RecorderLevel = recorderLevel;
        Location = location;
        LastUpdated = lastUpdated;
        Products = products;
    }
    public static Inventory Creatre(Guid productId,Quantity quantity,RecorderLevel recorderLevel,
        Location location,DateTimeOffset lastUpdated,List<Product>products)
    {
        var inventory = new Inventory(Guid.NewGuid(),productId,quantity,recorderLevel,location,lastUpdated,products);
        inventory.AddDomainEvent(new CreateInventoryDomainEvent(inventory.Id));
        return inventory;

    }
}