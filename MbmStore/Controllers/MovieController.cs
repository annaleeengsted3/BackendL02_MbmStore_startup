using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Walt Disney");
            var tarzan = new Movie("Tarzan", 120.80m, "tarzan.jpg", "Walt Disney");
            var frozen = new Movie("Frozen", 230.00m, "frozen.jpg", "Walt Disney");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Tarzan = tarzan;
            ViewBag.Frozen = frozen;

            //var movieArray = new Movie[] { jungleBook, tarzan, frozen};

            //USE THE LIST CLASS 

            List<Movie> moviesList = new List<Movie>();
            moviesList.Add(frozen);
            moviesList.Add(jungleBook);
            moviesList.Add(tarzan);

            ViewBag.Movies = moviesList;
            // return the default view
            return View();
        }
    }
}