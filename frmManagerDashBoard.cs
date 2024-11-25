using System;
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
        private CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();
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
            return context.Employees.Count(e => e.Role == "Barista");
        }

        public decimal IncomeToday()
        {
            DateTime today = DateTime.Today;
            return (decimal) context.Orders
                     .Where(o => o.OrderDate.Date == today)
                     .Sum(o => o.TotalAmount);
        }

        public decimal TotalIncome()
        {
            return (decimal)context.Orders.Sum(o => o.TotalAmount);
        }

        private void LoadData()
        {
            lblTotalcus.Text = TotalCustomers().ToString();
            lbltotalBar.Text = TotalBaristas().ToString();
            lblTodayIncome.Text = IncomeToday().ToString("N0") + " VND";
            lblTotalIncome.Text = TotalIncome().ToString("N0") + " VND";


        }


    }
}
