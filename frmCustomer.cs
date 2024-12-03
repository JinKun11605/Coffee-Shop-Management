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
    public partial class frmCustomer : Form
    {
        private string customerID;
        public frmCustomer(String CustomerID)
        {
            InitializeComponent();
            customerID = CustomerID;
            if (customerID == "GUEST")
            {
                btnInfo.Visible = false ;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmMenu frm = new frmMenu(customerID);
            pnMain.Controls.Add(frm);
        }

        private void imgLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmCustomerInfo frm = new frmCustomerInfo(customerID);
            pnMain.Controls.Add(frm);
        }
    }
}
