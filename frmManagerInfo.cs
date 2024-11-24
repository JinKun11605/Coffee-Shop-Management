using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmManagerInfo : Form
    {
        private string managerID;

        public string ManagerID { get => managerID; set => managerID = value; }

        public frmManagerInfo(string id)
        {
            InitializeComponent();
            ManagerID = id;
        }

        private void frmManagerInfo_Load(object sender, EventArgs e)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var manager = db.Employees.FirstOrDefault(u => u.EmployeeID == ManagerID);

            lblShowFullName.Text = manager.FullName;
            lblShowBirthDay.Text = manager.BirthDay.ToString("dd/MM/yyyy");
            lblShowHireDay.Text = manager.HireDay.ToString("dd/MM/yyyy");
            lblShowPhoneNumber.Text = manager.PhoneNumber;
            lblShowSalary.Text = manager.Salary.ToString();
            lblShowYoW.Text = manager.YoE.ToString();

            lblShowID.Text = manager.EmployeeID;
            lblShowPassword.Text = manager.Password;

            if (manager.Image != null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(manager.Image.ToArray());
                    pictureManager.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex.Message);
                }
            }
            else
            {
                pictureManager.Image = null;
            }
        }
        private void btnBarista_Click(object sender, EventArgs e)
        {
            frmBaristaList baristaList = new frmBaristaList();
            baristaList.Show();
        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerList customerList = new frmCustomerList();
            customerList.Show();
        }
        
        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.Show();
        }

        private void btnReportSales_Click(object sender, EventArgs e)
        {

        }

    }
}
