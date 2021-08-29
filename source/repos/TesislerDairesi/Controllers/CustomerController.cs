using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesislerDairesi.Models;

namespace TesislerDairesi.Controllers
{
    public class CustomerController : Controller
    {

        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Shery", Age = 12 });
            customers.Add(new CustomerModel { Id = 1, Name = "John", Age = 22 });
            customers.Add(new CustomerModel { Id = 2, Name = "Ted", Age = 32 });
            customers.Add(new CustomerModel { Id = 3, Name = "Sal", Age = 42 });

        }
        public IActionResult Index()
        {
            return View(customers);
        }
        public IActionResult ShowOnePerson( int Id)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.Id == Id);
            return PartialView(c);
        }

    }
}
