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

    public partial class frmBaristaInfo : UserControl
    {
        private string baristaID;
        public string BaristaID { get => baristaID; set => baristaID = value; }
        public frmBaristaInfo(string baristaID)
        {
            InitializeComponent();
            BaristaID = baristaID;
        }

        private void frmBaristaInfo_Load(object sender, EventArgs e)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var manager = db.Employees.FirstOrDefault(em => em.EmployeeID == BaristaID);

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

        private void btnBartending_Click(object sender, EventArgs e)
        {
            frmBaristaMixing frmBaristaUpdate = new frmBaristaMixing(baristaID);
            frmBaristaUpdate.Show();
        }
    }
}
