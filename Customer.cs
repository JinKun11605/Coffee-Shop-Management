using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopManagement
{
    public class CustomerInfo : Person
    {
        private string customerLevel;
        public string CustomerLevel { get => customerLevel; set => customerLevel = value; }
        public CustomerInfo() { }
        public CustomerInfo(string id, string password, string fullName, DateTime birthDay, string phoneNumber, string customerLevel) 
            : base(id, password, fullName, birthDay, phoneNumber)
        {
            CustomerLevel = customerLevel;
        }

    }
}