using Microsoft.AspNetCore.Mvc;
using BDTask_JonSiv.Models.DB;

namespace BDTask_JonSiv.Controllers
{
    public class CustomerController : Controller
    {
        //empty list of Customer type to store newly created customers for purpose of the test
        private static List<Customer> _customers = new List<Customer>();

        public IActionResult Index()
        {
            return View(_customers);
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
