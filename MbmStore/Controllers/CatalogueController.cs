using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            var Book1 = new Book("JK Rowling", "Harry Potter", 12,  1992);
            var Book2 = new Book("Zachary Auburn", "How To Talk To Your Cat About Gun Safety", 12,  2016);
            var CD1 = new MusicCD("Hansi Hinterseer", "Javol aus Tyrol", 2, 1994);
            CD1.AddTrack(new Track("Wir Trinken Alkohol"));
            CD1.AddTrack(new Track("Wir Trinken Sehr Viel Alkohol"));
            CD1.AddTrack(new Track("Ich möchte tanzen, tanzen"));  

            var CD2 = new MusicCD("Britney Spears", "...Baby One More Time", 8, 1999);
            CD2.AddTrack(new Track("...Baby One More Time"));
            CD2.AddTrack(new Track("(You Drive Me) Crazy"));
            CD2.AddTrack(new Track("Sometimes"));
            CD2.AddTrack(new Track("Soda Pop"));
            CD2.AddTrack(new Track("Email My Heart"));
            CD2.AddTrack(new Track("The Beat Goes On"));

            var CD3 = new MusicCD("Backstreet Boys", "Backstreets Back", 12234, 1997);
            CD3.AddTrack(new Track("Everybody"));
            CD3.AddTrack(new Track("As Long As You Love Me"));
            CD3.AddTrack(new Track("I Want It That Way"));
            CD3.AddTrack(new Track("Dingus Lingus"));
            CD3.AddTrack(new Track("Mr. Poopypants"));
            CD3.AddTrack(new Track("All I Have To Give"));

            var Movie1 = new Movie("Jungle Book", 160, "junglebook.jpg", "Walt Disney");
            var Movie2 = new Movie("Tarzan", 120, "tarzan.jpg", "Walt Disney");
            var Movie3 = new Movie("Frozen", 230, "frozen.jpg", "Walt Disney");

            List<Product> products = new List<Product>();
            products.Add(CD1);
            products.Add(CD2);
            products.Add(CD3);
            products.Add(Book1);
            products.Add(Book2);
            products.Add(Movie1);
            products.Add(Movie2);
            products.Add(Movie3);
            List<Book> books = new List<Book>();
            books = products.OfType<Book>().ToList();

            List<MusicCD> CDs = new List<MusicCD>();
            CDs = products.OfType<MusicCD>().ToList();

            List<Movie> Movies = new List<Movie>();
            Movies = products.OfType<Movie>().ToList();

            ViewBag.Books = books;
            ViewBag.CDs = CDs;
            ViewBag.Movies = Movies;

        
           
            return View();
        }
    }
}
