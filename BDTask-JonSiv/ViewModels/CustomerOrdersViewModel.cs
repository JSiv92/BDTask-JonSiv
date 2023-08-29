using BDTask_JonSiv.Models.DB;

namespace BDTask_JonSiv.ViewModels
{
    //custom viewmodel in order to join customer and orders table to get order count per customer id
    public class CustomerOrdersViewModel
    {
        public Customer? Customer { get; set; }
        public int OrderCount { get; set; }
    }
}
