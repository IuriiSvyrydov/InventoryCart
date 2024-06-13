

using InventoryCart.Application.Messaging;

namespace InventoryCart.Application.Category
{
    public record GetCategoryQuery(Guid CategoryId): IQuery<CategoryResponse>;
    
}
