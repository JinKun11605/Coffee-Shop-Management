﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public class BaristaInfo : Person
    {
        private DateTime hireDay;
        private int yoE;
        private decimal salary;
        private byte[] image;

        public DateTime HireDay { get => hireDay; set => hireDay = value; }
        public int YoE { get => yoE; set => yoE = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public byte[] Image { get => image; set => image = value; }

        public BaristaInfo() { }

        public BaristaInfo(string id, string password, string fullName, DateTime birthDay, string phoneNumber,
            DateTime hireDay, int yoE, decimal salary)
            : base(id, password, fullName, birthDay, phoneNumber)
        {
            HireDay = hireDay;
            YoE = yoE;
            Salary = salary;
        }
        public override string PrintDetails()
        {
            return base.PrintDetails() + $"Ngày thuê: {HireDay} \nKinh nghiệm: {YoE} Năm \nLương: {Salary} \n\n";
        }
        public string Mixing(string name, string size, int quantity)
        {
            return $"Tên: {name}, kích thước: {size}, số lượng: {quantity} \n";
        }
    }
}
