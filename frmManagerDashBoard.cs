﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmManagerDashBoard : UserControl
    {
        CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();
        
        public frmManagerDashBoard()
        {
            InitializeComponent();
            LoadData();
        }

        public int TotalCustomers()
        {
            return context.Customers.Count();
        }

        public int TotalBaristas()
        {
            return context.Baristas.Count();
        }

        public decimal IncomeToday()
        {
            DateTime today = DateTime.Today;

            return context.Orders
                          .Where(o => o.OrderDate.Date == today)
                          .Sum(o => (decimal?)o.TotalAmount) ?? 0;
        }

        public decimal TotalIncome()
        {
            return context.Orders.Sum(o => (decimal?)o.TotalAmount) ?? 0;
        }

        private void LoadData()
        {
            lblTotalcus.Text = TotalCustomers().ToString();
            lbltotalBar.Text = TotalBaristas().ToString();
            lblTodayIncome.Text = IncomeToday().ToString("N0") + " VND";
            lblTotalIncome.Text = TotalIncome().ToString("N0") + " VND";
        }

        private void btnCoffeeInfo_Click(object sender, EventArgs e)
        {
            var coffees = context.Products.ToList();

            string result = "";

            foreach (var coffee in coffees)
            {
                Coffee drink = new Coffee(coffee.ProductID, coffee.ProductName, coffee.Size, coffee.Price, coffee.Quantity);
                result += drink;
                result += "\n";
            }

            lblCoffeeInfo.Text = result;
        }
    }
}
