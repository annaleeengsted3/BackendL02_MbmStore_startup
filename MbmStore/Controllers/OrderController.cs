using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;
        public OrderController(Cart cartService)
        {
            cart = cartService;
        }
        public ViewResult Checkout()
        {
            return View(new Order());
        }

        //The Checkout method is executed when a user pesses the "Checkout" button, returns the default view and passes 
        //an empty new Order object as the view model. The view: Views/Order/Checkout.cshtml


        //this method is invoked on a POST request (form submit)

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count == 0) { 
                ModelState.AddModelError("", "Sorry, your cart is empty!"); 
            }
            if (ModelState.IsValid)
            { 
                // order processing logic 
                cart.Clear(); 
                return View("Completed"); 
            }
            else 
            { 
                return View(order); } }
            }
}
