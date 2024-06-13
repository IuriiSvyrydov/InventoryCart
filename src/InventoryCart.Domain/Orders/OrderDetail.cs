using InventoryCart.Domain.Abstractions;
using InventoryCart.Domain.Orders.Events;
using InventoryCart.Domain.Products;
using InventoryCart.Domain.Products.Shared;


namespace InventoryCart.Domain.Orders
{
    public sealed class OrderDetail : Entity
    {
        public int Quantity { get; private set; }
        public Money TotalPrice { get; private set; }
        public Guid OrderID { get; private set; }
        public  Order Order { get; private set; } 
        public Guid ProductId { get; private set; }
        public  Product Product { get; private set; } 

        private OrderDetail()
        { }
        public OrderDetail(Guid id, Guid orderId, Guid productId,
         int quantity, Money totalPrice, Order order,
        Product product) : base(id)
        {
            OrderID = orderId;
            ProductId = productId;
            Quantity = quantity;
            Order = order;
            Product = product;
        }
        public static OrderDetail Create(Guid orderId, Guid productId,
         int quantity, Money totalPrice, Order order,
        Product product)
        {
            var orderDetail = new OrderDetail(Guid.NewGuid(),orderId,
                productId,quantity,totalPrice,order,product);
            orderDetail.AddDomainEvent(new CreateOrderDetailDomainEvent(orderDetail.Id));
            return orderDetail;
        }
    }
}
