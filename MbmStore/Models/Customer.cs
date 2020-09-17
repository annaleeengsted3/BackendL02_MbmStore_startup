using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;

namespace MbmStore.Models
{
    public class Customer
    {
        //shortcut: "prop" + tab

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
        public string  Zip { get; set; }
        public string  City { get; set; }

    
        private DateTime birthDate;
        private int age;
        public DateTime BirthDate
        {
          
            set
            {
             
                if (DateTime.Now.Year - value.Year > 120 || DateTime.Now.Year - value.Year <0)
                { throw new Exception("Age not accepted" + this.Age + "birthday year:" + birthDate); }
                else { birthDate = value; }
       
            }
            get
            {
                return birthDate;
            }

        }

        public int Age { 
            get {
            
                DateTime now = DateTime.Now; 
                int age;
                age = now.Year - birthDate.Year;

                // calculate to see if the customer hasn’t had her birthday yet // subtract one year if that is so 
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            } }

        //both of these properties for PhoneNumbers are read-only?:
        //public List<string> PhoneNumbers
        //{
        //    get
        //    {
        //        return phoneNumbers;
        //    }

        //}

        public List<string> PhoneNumbers { get; private set; } = new List<string>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();



        //shortcut: "ctor" + tab tab
     
        //public Customer(string firstName, string lastName, string address, string zip, string city)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Address = address;
        //    Zip = zip;
        //    City = city;
        //    //PhoneNumber = phoneNumber;
        //    //BirthDate = birthDate;


        //}

        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
         


        }


        public void AddPhone(string phone){
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
           
            Invoices.Add(invoice);
        }


    }



}
