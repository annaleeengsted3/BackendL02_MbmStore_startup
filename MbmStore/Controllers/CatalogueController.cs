using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Infrastructure;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;
        // GET: Catalogue
        public IActionResult Index(int page = 1)
        {


            ProductsListViewModel model = new ProductsListViewModel(); 
            model = new ProductsListViewModel
            {
                //pagination:
                Products = Repository.Products.OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page, 
                    ItemsPerPage = PageSize, 
                    TotalItems = Repository.Products.Count() }
            };
            return View(model);

            //These changes pass a ProductsListViewModel object as the model data to the view.









        }
    }
}
