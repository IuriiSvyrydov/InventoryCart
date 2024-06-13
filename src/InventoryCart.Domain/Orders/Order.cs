
using InventoryCart.Domain.Abstractions;

namespace InventoryCart.Domain.Orders
{
    public sealed class Order: Entity
    {
        public Guid SupplierId { get; private set; }
        public DateTimeOffset OrderDate { get; private set; }
        public int TotalAmount { get; private set; }
        public Status Status { get; private set; }
        public DateTimeOffset ExpectedDeliveryDate { get; private set; }
        public int OrderType { get; private set; }
        public DateTimeOffset ReceivedDate { get; private set; }
        public List<OrderDetail> OrderDetails { get; private set; } = new();

        private Order()
        {

        }
        public Order(Guid id,Guid supplierId,DateTimeOffset orderDate,
                int totalAmount, Status status,
                DateTimeOffset expectedDeliveryDate,
                int orderType,DateTimeOffset receivedDate,
                List<OrderDetail>orderDetails):base(id)
        {
            SupplierId = supplierId;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = status;
            ExpectedDeliveryDate = expectedDeliveryDate;
            OrderType = orderType;
            ReceivedDate = receivedDate;
            OrderDetails = orderDetails;
        }
        public static Order Create()
        {
            return null;
        }

    }
}
