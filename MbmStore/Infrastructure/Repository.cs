using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        // List of products and invoices
        public static List<Product>Products= new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        //ctr
        
        static Repository()
        {
            // create objects 
            Book Book1 = new Book(1, "JK Rowling", "Harry Potter", 180.00M, 1992);
            Book1.ISBN = "9780439554930";
            Book1.Publisher = "Scholastic";
            Book1.ImageFileName = "/Images/harrypotter.jpg";
            Book Book2 = new Book(2, "Zachary Auburn", "How To Talk To Your Cat About Gun Safety", 150.00M, 2016);
            Book2.ISBN = "978-0451494924";
            Book2.Publisher = "Three Rivers Press";
            Book2.ImageFileName = "/Images/gunsafety.jpg";

            MusicCD CD1 = new MusicCD(3, "Hansi Hinterseer", "Javol aus Tyrol", 99, 1994);
            CD1.ImageFileName = "/Images/hansi.jpg";
            CD1.AddTrack(new Track("Wir Trinken Alkohol"));
            CD1.AddTrack(new Track("Wir Trinken Sehr Viel Alkohol"));
            CD1.AddTrack(new Track("Ich möchte tanzen, tanzen"));

            MusicCD CD2 = new MusicCD(4, "Britney Spears", "...Baby One More Time", 80, 1999);
            CD2.ImageFileName = "/Images/britney.jpg";
            CD2.AddTrack(new Track("...Baby One More Time"));
            CD2.AddTrack(new Track("(You Drive Me) Crazy"));
            CD2.AddTrack(new Track("Sometimes"));
            CD2.AddTrack(new Track("Soda Pop"));
            CD2.AddTrack(new Track("Email My Heart"));
            CD2.AddTrack(new Track("The Beat Goes On"));

            MusicCD CD3 = new MusicCD(5, "Backstreet Boys", "Backstreets Back", 599, 1997);
            CD3.ImageFileName = "/Images/backstreet.jpg";
            CD3.AddTrack(new Track("Everybody"));
            CD3.AddTrack(new Track("As Long As You Love Me"));
            CD3.AddTrack(new Track("I Want It That Way"));
            CD3.AddTrack(new Track("Dingus Lingus"));
            CD3.AddTrack(new Track("Mr. Poopypants"));
            CD3.AddTrack(new Track("All I Have To Give"));

            Movie Movie1 = new Movie(6, "Jungle Book", 160, "/Images/junglebook.jpg", "Walt Disney");
            Movie Movie2 = new Movie(7, "Tarzan", 120, "/Images/tarzan.jpg", "Walt Disney");
            Movie Movie3 = new Movie(8, "Frozen", 230, "/Images/frozen.jpg", "Walt Disney");

           
            Products.Add(CD1);
            Products.Add(CD2);
            Products.Add(CD3);
            Products.Add(Book1);
            Products.Add(Book2);
            Products.Add(Movie1);
            Products.Add(Movie2);
            Products.Add(Movie3);

            Customer cust1 = new Customer(1, "John", "Doe", "Somestreet 27", "8464", "Somecity");
            Customer cust2 = new Customer(2, "Jane", "Doe", "Otherstreet 13", "2000", "Othercity");
            Customer cust3 = new Customer(3, "Adam", "Smith", "Nextstreet 69", "4200", "Nextcity");
            cust1.AddPhone("11223344");
            cust2.AddPhone("12345678");
            cust2.AddPhone("00998877");
            cust3.AddPhone("69696969");
            cust1.BirthDate = new DateTime(2016, 7, 15);
            cust2.BirthDate = new DateTime(1992, 7, 15);
            cust3.BirthDate = new DateTime(1990, 7, 15);


            Invoice Invoice1 = new Invoice(1, new DateTime(2020, 7, 16), cust1);
            Invoice1.AddOrderItem(CD3, 1);
            Invoice1.AddOrderItem(Book2, 3);
            Invoice Invoice2 = new Invoice(2, new DateTime(2020, 5, 13), cust2);
            Invoice2.AddOrderItem(Movie2, 2);
            Invoice2.AddOrderItem(Book1, 7);

            Invoice Invoice3 = new Invoice(3, new DateTime(2020, 9, 9), cust3);
            Invoice3.AddOrderItem(Movie2, 2);

            Invoice Invoice4 = new Invoice(4, new DateTime(2020, 4, 9), cust1);
            Invoice4.AddOrderItem(Movie2, 2);


            Invoices.Add(Invoice1);
            Invoices.Add(Invoice2);
            Invoices.Add(Invoice3);
            Invoices.Add(Invoice4);

        }
    }
}
