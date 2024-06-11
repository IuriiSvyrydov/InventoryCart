using InventoryCart.Domain.Abstractions;
using InventoryCart.Domain.Categories;
using InventoryCart.Domain.Products.Events;
using InventoryCart.Domain.Products.Shared;

namespace InventoryCart.Domain.Products;

public sealed class Product: Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; } 
    public Money UnitPrice { get; private set; }
    public float Weight { get; private set; }
    public float Length { get; private set; }
    public float Width { get; private set; }
    public float Height { get; private set; }
    public Guid CategoryId { get; private set; }
    public List<Category> Categories { get; private set; } = new();
    public Money TaxCost { get; private set; }
    public Money  ProfitPerUnit { get;private set; }
    public Money ProductionCost { get; private set; }
    private Product()
    {
        
    }

    public Product(Guid id,
        Guid categoryId,
        Name name,
        Description description,
        Money unitPrice,
        float weight,
        float length,
        float width,
        float height,
        List<Category> categories,
        Money taxCost,
        Money profitPerUnit,
        Money productionCost):base(id)
    {
        CategoryId = categoryId;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Weight = weight;
        Length = length;
        Width = width;
        Height = height;
        Categories = categories;
        TaxCost = taxCost;
        ProfitPerUnit = profitPerUnit;
        ProductionCost = productionCost;
    }
    //static factory

    public static Product Create(Guid categoryId, Name name,
                            Description description, Money unitPrice,
                            float weight,
                            float length,
                            float width,float height,
                            List<Category>categories,
                            Money taxCost,
                            Money profitPerUnit,
                            Money productionCost)
    {
        var product = new Product(Guid.NewGuid(), categoryId,
            name, description, unitPrice, weight, length,
            width, height, categories, taxCost, profitPerUnit, productionCost);
        product.AddDomainEvent(new CreateProductDomainEvent(product.Id));
        return product;
      
    }
}