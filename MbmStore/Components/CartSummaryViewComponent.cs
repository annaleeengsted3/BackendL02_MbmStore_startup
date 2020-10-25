﻿using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace MbmStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
            
}
    }
}