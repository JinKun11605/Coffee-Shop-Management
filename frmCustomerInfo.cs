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
    public partial class frmCustomerInfo : UserControl
    {
        private string customerID;
        public string CustomerID { get => customerID; set => customerID = value; }
        public frmCustomerInfo(string customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }
        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);

            lblShowFullName.Text = customer.FullName;
            lblShowBirthDay.Text = customer.BirthDay.ToString("dd/MM/yyyy");
            lblShowPhoneNumber.Text = customer.PhoneNumber;
            lblShowID.Text = customer.CustomerID;
            lblShowPassword.Text = customer.Password;
            lblShowLevel.Text = customer.CustomerLevel;

            // Goi method CustomerInfo
            var customerInfo = new CustomerInfo(customer.CustomerID, customer.Password, customer.FullName, customer.BirthDay, customer.PhoneNumber, customer.CustomerLevel);
            MessageBox.Show($"{customerInfo.PrintDetails()}", "THÔNG TIN KHÁCH HÀNG");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu(CustomerID);
            frmmenu.Show();
        }
    }
}
