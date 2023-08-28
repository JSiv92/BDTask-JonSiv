namespace BDTask_JonSiv.Models.DB
{
    //this is a bridging table. An Order.cs is composed of 1 to many order items
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        //the order id this particular orderitem belongs to:
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Subtotal { get; set; }

        //the price at the time of ordering:
        public decimal PriceAtOrder { get; set; }


        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
