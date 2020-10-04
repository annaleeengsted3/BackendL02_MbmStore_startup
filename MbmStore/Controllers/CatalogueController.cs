using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {

            List<Book> Books = new List<Book>();
            Books = Repository.Products.OfType<Book>().ToList();

            List<MusicCD> CDs = new List<MusicCD>();
            CDs = Repository.Products.OfType<MusicCD>().ToList();

            List<Movie> Movies = new List<Movie>();
            Movies = Repository.Products.OfType<Movie>().ToList();

            ViewBag.Books = Books;
            ViewBag.CDs = CDs;
            ViewBag.Movies = Movies;

    



            return View(Repository.Products);
        }
    }
}
