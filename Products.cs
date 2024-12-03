using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopManagement
{
    public class Products
    {
        private string productID;
        private string productName;     
        private string size;           
        private decimal price;        
        private double discount;        
        private int quantity;

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Size { get => size; set => size = value; }
        public decimal Price { get => price; set => price = value; }
        public double Discount { get => discount; set => discount = value; }
        public int Quantity { get => quantity; set => quantity = value; }


    }
}