using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
     
        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    Price = value;
                }
            }

            get { return Price; }
        }
        public string ImageFileName { get; set; }

        public Product() { }
        public Product(string title, decimal price) {
            Title = title;
            Price = price;
            //default image just for the view right now, change later:
            ImageFileName = "https://via.placeholder.com/250";
        }

    }
}
