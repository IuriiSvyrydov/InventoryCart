using InventoryCart.Domain.Abstractions;
using InventoryCart.Domain.Categories.Events;
using InventoryCart.Domain.Products;

namespace InventoryCart.Domain.Categories;

public sealed class Category : Entity
{
    #region Properties
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public List<Product> Products { get; private set; }

    #endregion

    #region constructors and simple methods

    private Category()
    { 
    }
    public Category(Guid id,Name name,Description description, List<Product>products):base(id)
    {
        Name = name;
        Description = description;
        Products = products;
    }

    public static Category Create(Name name, Description description,List<Product>products)
    {
        var category = new Category(Guid.NewGuid(), name, description, products);
        category.AddDomainEvent(new CreateCategoryDomainEvent(category.Id));
        return category;
    }
    #endregion

}