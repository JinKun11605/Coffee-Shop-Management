using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

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

        public override string PrintDetails()
        {
            return base.PrintDetails() + $"Hạng: {CustomerLevel}";
        }

        public void Order(List<OrderDetails> orders)
        {
            string result = "";
            foreach (var order in orders)
            {
                result += order.ToString();
            }

            MessageBox.Show(result, "CÁC MÓN ĐÃ GỌI");
        }

        public void HandlePaymnent(decimal money)
        {
            MessageBox.Show($"Số tiền đã thanh toán: {money.ToString("N0")} VND", "THANH TOÁN");
        }

        public void FeedBack( int star, TextBox textBox)
        {
            string res = $"Đánh giá {star} sao  \nLời nhắn: {textBox.Text}";
            MessageBox.Show(res, "FEEDBACK");
        }
    }
}