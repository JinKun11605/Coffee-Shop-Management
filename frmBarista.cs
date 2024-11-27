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
    public partial class frmBarista : Form
    {
        private string baristaID;
        public frmBarista(string BaristaID)
        {
            InitializeComponent();
            this.baristaID = BaristaID;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmBaristaInfo frm = new frmBaristaInfo(baristaID);
            pnMain.Controls.Add(frm);
        }

       

        private void btnMixing_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmBaristaMixing frm = new frmBaristaMixing(baristaID);
            pnMain.Controls.Add(frm);
        }







        private void imgLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
