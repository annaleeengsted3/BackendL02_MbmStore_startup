using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            var invoices = Repository.Invoices;
            ViewBag.Invoices = invoices;

            return View();
        }
    }
}
