

namespace InventoryCart.Domain.Orders
{
    public enum Status
    {
        Reserved=1,
        Confirmed = 2,
        Rejected=3,
        Cancelled = 4,
        Completed = 5
    }
}
