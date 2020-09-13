using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
    
        private string director;

        // properties
        //public string Title { get; }
        public string Director {
            set { director = value; }
            get { return director; }
        }



       //public string ImageFileName { get; set; }

        //public decimal Price
        //{
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            throw new Exception("Price is not accepted");
        //        }
        //        else
        //        {
        //            price = value;
        //        }
        //    }
        //    get { return price; }
        //}


        // constructors
        public Movie() { }

        public Movie(string title, decimal price) : base(title, price)
        {
        }

        public Movie(string title, decimal price, string imageFileName, string director) : base(title, price)
        {
   
            ImageFileName = imageFileName;
            Director = director;
        }
    }
}