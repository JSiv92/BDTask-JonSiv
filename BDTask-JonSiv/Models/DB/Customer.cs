namespace BDTask_JonSiv.Models.DB
{
    public class Customer
    {
        //start creating ID's from 1000
        //(this is setup to auto increment in mssql server but i have done this so it works when im adding objects to my static customer List in Part 2)
        private static int _nextId = 1000;

        //constructor to set the dateregistered to current date and generate an ID
        public Customer()
        {
            Id = _nextId++;
            DateRegistered = DateTime.Now;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateRegistered { get; set; }

        //all orders for this customer
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
