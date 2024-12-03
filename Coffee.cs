using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopManagement
{
    public class Coffee
    {
        private string id;
        private string name;
        private string size;
        private decimal price;
        private int quantity;

        public Coffee()
        {
        }

        public Coffee(string id, string name, string size, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = price;
            Quantity = quantity;

        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Size { get => size; set => size = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Name}, Kích thước: {Size}, Giá: {Price}, Số lương: {Quantity} \n";
        }
    }
}