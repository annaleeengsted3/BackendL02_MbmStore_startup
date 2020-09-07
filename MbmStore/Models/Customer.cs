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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
        public string  Zip { get; set; }
        public string  City { get; set; }

        //private List<string> phoneNumbers;
        //private List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;
        private int age;
        public DateTime BirthDate
        {
          
            set
            {
                //also dumb, have to assign birthdate the value before validating- fix***
                //birthDate = value;
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

        //both are right

        //public List<string> PhoneNumbers
        //{
        //    get
        //    {
        //        return phoneNumbers;
        //    }

        //}

        public List<string> PhoneNumbers { get; private set; } = new List<string>();



        //shortcut: "ctor" + tab tab
        //Constructor:
        public Customer(string firstName, string lastName, string address, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
            //PhoneNumber = phoneNumber;
            //BirthDate = birthDate;


        }


        public void AddPhone(string phone){
            //phoneNumbers.Add(phone);
            PhoneNumbers.Add(phone);
        }


    }



}
