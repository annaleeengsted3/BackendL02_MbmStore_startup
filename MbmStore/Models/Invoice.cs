using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        public decimal TotalPrice
        {
            get
            {
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalPrice = totalPrice + orderItem.TotalPrice;
                }
                //alternative solution (need LINQ):
                //return orderItems.Sum(item=> item.TotalPrice*item.Quantity);
                return totalPrice;
            }
        }
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
       

        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();



        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }


        public void AddOrderItem(Product product, int quantity)
        {

            OrderItems.Add(new OrderItem(product, quantity));
        }

    }
}
