using InventoryCart.Domain.Abstractions;

namespace InventoryCart.Domain.Products;

public sealed class Product: Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
}