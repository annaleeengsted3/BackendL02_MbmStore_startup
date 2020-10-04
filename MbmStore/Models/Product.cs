﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        private decimal price { get; set; }

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
                    price = value;
                }
            }

            get { return price; }
        }
        public string ImageFileName { get; set; }

        public Product() { }
        public Product(int productId, string title, decimal price) {
            Title = title;
            Price = price;
            ProductId = productId;
            //default image just for the sake of the view right now, change later:
            ImageFileName = "https://via.placeholder.com/200";
        }

    }
}
