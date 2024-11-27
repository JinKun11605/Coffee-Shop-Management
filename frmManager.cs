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
    public partial class frmManager : Form
    {
        private string managerID;
        public frmManager(string MananegerID)
        {
            InitializeComponent();
            managerID = MananegerID;
            pnMain.Controls.Clear();
            frmManagerDashBoard frm = new frmManagerDashBoard();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }
        private void ReserColor()
        {
            btnDashBoard.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnDashBoard.ForeColor = Color.White;

            btnInfo.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnInfo.ForeColor = Color.White;

            btnBarista.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnBarista.ForeColor = Color.White;

            btnCustomer.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnCustomer.ForeColor = Color.White;

            btnInventory.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnInventory.ForeColor = Color.White;

            btnReport.FillColor = ColorTranslator.FromHtml("#5E94FF");
            btnReport.ForeColor = Color.White;
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnInfo.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnInfo.FillColor = Color.White;
            pnMain.Controls.Clear();
            frmManagerInfo frm = new frmManagerInfo(managerID);
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnInventory.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnInventory.FillColor = Color.White;
            pnMain.Controls.Clear();
            frmInventory frm = new frmInventory();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnBarista_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnBarista.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnBarista.FillColor = Color.White;
            pnMain.Controls.Clear();
            frmBaristaList frm = new frmBaristaList();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnCustomer.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnCustomer.FillColor = Color.White;
            pnMain.Controls.Clear();
            frmCustomerList frm = new frmCustomerList();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnDashBoard.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnDashBoard.FillColor = Color.White;

            pnMain.Controls.Clear();
            frmManagerDashBoard frm = new frmManagerDashBoard();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }


        private void imgLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            ReserColor();
            btnReport.ForeColor = ColorTranslator.FromHtml("#5E94FF");
            btnReport.FillColor = Color.White;


            ///
        }
    }
}
