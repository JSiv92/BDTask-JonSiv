namespace BDTask_JonSiv.Models.DB
{
    public class Order
    {
        //constructor to set the dateordered to now
        public Order()
        {
            DateOrdered = DateTime.Now;
        }

        public int OrderId { get; set; }

        public DateTime DateOrdered { get; set; }

        public decimal TotalPrice { get; set; }
        //the customer this order belongs to:
        public int CustomerId { get; set; }

        //the actual list of orderitems for any given order:
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public virtual Customer OrderNavigation { get; set; } = null!;
    }
}
