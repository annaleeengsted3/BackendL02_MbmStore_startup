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
            Movie Movie1 = new Movie(6, "Jungle Book", 160, "/Images/junglebook.jpg", "Walt Disney");
            Movie Movie2 = new Movie(7, "Tarzan", 120, "/Images/tarzan.jpg", "Walt Disney");
            Movie Movie3 = new Movie(8, "Frozen", 230, "/Images/frozen.jpg", "Walt Disney");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = Movie1;
            ViewBag.Tarzan = Movie2;
            ViewBag.Frozen = Movie3;

            //var movieArray = new Movie[] { jungleBook, tarzan, frozen};

            //USE THE LIST CLASS 

            List<Movie> moviesList = new List<Movie>();
            moviesList.Add(Movie1);
            moviesList.Add(Movie2);
            moviesList.Add(Movie3);

            ViewBag.Movies = moviesList;
            // return the default view
            return View();
        }
    }
}