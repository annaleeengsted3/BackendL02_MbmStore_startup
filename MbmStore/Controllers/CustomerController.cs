using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var cust1 = new Customer(1, "John", "Doe", "Somestreet 27", "8464", "Somecity");
            var cust2 = new Customer(2, "Jane", "Doe", "Otherstreet 13", "2000", "Othercity");
            var cust3 = new Customer(3, "Moe", "Lester", "Shadystreet 69", "4200", "Shadycity");
            //this is dumb:
         
            cust1.AddPhone("11223344");
            cust2.AddPhone("12345678");
            cust2.AddPhone("00998877");
            cust3.AddPhone("69696969");

            cust1.BirthDate = new DateTime(2016, 7, 15);
            cust2.BirthDate = new DateTime(1992, 7, 15);
            cust3.BirthDate = new DateTime(1990, 7, 15);


         List<Customer> customers = new List<Customer>();
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);

            ViewBag.Customers = customers;


            return View();
        }
    }
}
