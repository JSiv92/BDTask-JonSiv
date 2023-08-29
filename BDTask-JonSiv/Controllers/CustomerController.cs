using Microsoft.AspNetCore.Mvc;
using BDTask_JonSiv.Models.DB;
using BDTask_JonSiv.ViewModels;

namespace BDTask_JonSiv.Controllers
{
    public class CustomerController : Controller
    {
        //storing customers+orders in memory for purpose of this test
        //ideally id want the orders seperated in their own controller
        private static List<Customer> _customers = new List<Customer>();
        private static List<Order> _orders = new List<Order>();

        //func to init the mock data 
        private void InitialiseSampleData()
        {
            if (_customers.Count == 0 && _orders.Count == 0)
            {
                //two sample customers
                Customer customer1 = new Customer { FirstName = "John", LastName = "Jones", Address = "12 Jupiter St", Phone = "027" };
                Customer customer2 = new Customer { FirstName = "Steve", LastName = "Jobs", Address = "400 Mt Eden Rd", Phone = "021" };

                //sample orders - the last 2 orders are for the first user-created customer
                var orders = new List<Order>
                {
                    new Order { OrderId = 1, CustomerId = 1000, TotalPrice = 50 },
                    new Order { OrderId = 2, CustomerId = 1001, TotalPrice = 52 },
                    new Order { OrderId = 3, CustomerId = 1001, TotalPrice = 70 },
                    new Order { OrderId = 4, CustomerId = 1002, TotalPrice = 100 },
                    new Order { OrderId = 5, CustomerId = 1002, TotalPrice = 250 }
                };

                //add orders to the _order list
                _orders.AddRange(orders);

                //add customers to the customer list
                _customers.Add(customer1);
                _customers.Add(customer2);
            }
        }

        //call the above function in controller's ctor
        public CustomerController()
        {
            InitialiseSampleData();
        }

        // GET method using linq query to convert a customer into a viewmodel with order count value
        public IActionResult Index()
        {
            var customerViewModels = from customer in _customers
                                     join order in _orders
                                     on customer.Id equals order.CustomerId
                                     into customerOrders //group the orders by customerOrder count
                                     select new CustomerOrdersViewModel
                                     {
                                         Customer = customer,
                                         OrderCount = customerOrders.Count()
                                     };

            return View(customerViewModels.ToList());
        }

        //GET method to get the Customer create form:
        public IActionResult Create()
        {
            return View();
        }

        //POST method to add the new customer to the _customer list on submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customers.Add(customer);
            }
            return View(customer);
        }
    }
}
