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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmManagerInfo frm = new frmManagerInfo("m1");
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

            pnMain.Controls.Clear();
            frmInventory frm = new frmInventory();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnBarista_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmBaristaList frm = new frmBaristaList();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmCustomerList frm = new frmCustomerList();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmManagerDashBoard frm = new frmManagerDashBoard();
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
        }
    }
}
