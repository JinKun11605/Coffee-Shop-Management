using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    public class OrderDetails
    {

        private string productID;
        private string productName;
        private decimal price;
        private int quantity;
        private string size;
        private double discount;
        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public string Size { get => size; set => size = value; }
        public double Discount { get => discount; set => discount = value; }
    }
}
