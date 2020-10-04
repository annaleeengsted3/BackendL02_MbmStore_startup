using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;
        public CartController(Cart cartService)
        {
            cart = cartService;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
        public RedirectToActionResult AddToCart(int productID, string returnUrl, int quantity)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                cart.AddItem(product, quantity);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using MbmStore.Models;
//using MbmStore.Infrastructure;
//using MbmStore.Models.ViewModels;

//namespace MbmStore.Controllers
//{
//    public class CartController : Controller
//    {

//        //using parameter names that match with the hidden input elements in the form created in catalogue view. Allows MVC to associate incoming POST variables = MODEL BINDING
//        public RedirectToActionResult AddToCart(int productID, string returnUrl)
//        {
//            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);
//            if (product != null)
//            {
//                Cart cart = GetCart();
//                cart.AddItem(product, 1);
//                SaveCart(cart);
//            }
//            return RedirectToAction("Index", new { returnUrl });
//        }
//        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
//        {
//            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);
//            if (product != null)
//            {
//                GetCart().RemoveLine(product);
//            }
//            return RedirectToAction("Index", new { returnUrl });
//        }

//        //using ASP.NET session state feature to store and retrieve Cart objects:
//        private Cart GetCart()
//        {
//            //using the other extension mehtod specifying the same key:
//            Cart cart = HttpContext.Session.GetJson<Cart>("Cart");
//            if (cart == null)
//            {
//                cart = new Cart();
//                //adds a cart to the session state:
//                HttpContext.Session.SetJson("Cart", cart);
//                //HTTPContext returns an HttpContext object with context data about the request and the response that is being prepared
//                //.Session returns an object that implements the ISession interface (the type we defined SetJson() )
//            }
//            return cart;
//        }
//        private void SaveCart(Cart cart)
//        {
//            HttpContext.Session.SetJson("Cart", cart);
//        }
//        public ViewResult Index(string returnUrl)
//        {
//            return View(new CartIndexViewModel
//            {
//                Cart = GetCart(),
//                ReturnUrl = returnUrl
//            });
//        }



//    }
//}
